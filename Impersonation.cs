using Microsoft.Win32.SafeHandles;
using System;
using System.ComponentModel;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Principal;

namespace Keylogger
{
    public static class Impersonation
    {
        #region Dll imports

        [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool LogonUser(String lpszUsername, String lpszDomain, String lpszPassword,
            int dwLogonType, int dwLogonProvider, out SafeTokenHandle phToken);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public extern static bool CloseHandle(IntPtr handle);

        #endregion

        #region constants

        private const int LOGON32_PROVIDER_DEFAULT = 0;
        private const int LOGON32_LOGON_INTERACTIVE = 2;

        #endregion

        public static WindowsIdentity GetWindowsIdentity(string domainNameOrLocalMachineName, string userName, string userPassword)
        {
            SafeTokenHandle safeTokenHandle;
            try
            {
                /*
                 * Call LogonUser to obtain a handle to an access token. It passes user, domain and password and tries to get a token for that
                 * user in that domain with that password, it saves the token in safeTokenHandle. It also returns a bool representing success or failure.
                 */
                bool success = LogonUser(userName, domainNameOrLocalMachineName, userPassword,
                    LOGON32_LOGON_INTERACTIVE, LOGON32_PROVIDER_DEFAULT, out safeTokenHandle);
                if (success)
                    return new WindowsIdentity(safeTokenHandle.DangerousGetHandle());
                else
                {
                    int errorCode = Marshal.GetLastWin32Error();
                    throw new Win32Exception(errorCode, "LogonUser failed, GetLastWin32Error error code: " + errorCode);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static WindowsImpersonationContext GetWindowsImpersonationContext(string domainNameOrLocalMachineName, string userName, string userPassword)
        {
            return GetWindowsIdentity(domainNameOrLocalMachineName, userName, userPassword).Impersonate();
        }
    }

    public sealed class SafeTokenHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        private SafeTokenHandle() : base(true) { }

        [DllImport("kernel32.dll")]
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        [SuppressUnmanagedCodeSecurity]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool CloseHandle(IntPtr handle);

        protected override bool ReleaseHandle()
        {
            return CloseHandle(handle);
        }
    }
}
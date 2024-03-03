using System;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace RustServerManager.Tools
{
    public static class FormTools
    {
        // constants for mouse window events
        public const int HT_CAPTION = 0x2;
        public const int WM_NCLBUTTONDOWN = 0xA1;

        // import the SendMessage and ReleaseCapture functions from user32.dll
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        // method to move the form when the mouse is clicked and dragged
        public static void MoveForm(IntPtr handle, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public static string OpenFolderBrowserDialog()
        {
            Tools.LogTools.LogEvent("FORM/INFO", "Opening folder browser dialog...", false, false, ConsoleColor.Gray);

            using (OpenFileDialog selectFolderDialog = new OpenFileDialog())
            {
                selectFolderDialog.Multiselect = false;
                selectFolderDialog.CheckFileExists = false;
                selectFolderDialog.CheckPathExists = true;
                selectFolderDialog.FileName = "Select a folder";
                selectFolderDialog.Filter = "Directories|Folders";
                selectFolderDialog.ShowDialog();

                if (selectFolderDialog.FileName != "Select a folder" && selectFolderDialog.FileName != null)
                {
                    string folderPath = Path.GetDirectoryName(selectFolderDialog.FileName);
                    return folderPath;
                }
                return "";
            }
        }
    }
}
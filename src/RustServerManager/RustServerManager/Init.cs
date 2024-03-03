using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Windows.Forms;

using static RustServerManager.Global;

namespace RustServerManager
{
    internal static class Init
    {
        [STAThread]
        static void Main()
        {
            if (!Directory.Exists("RustServerManager\\logs"))
                Directory.CreateDirectory("RustServerManager\\logs");

            LOG_DATETIME = DateTime.Now;
            Tools.LogTools.LogEvent("INIT/INFO", "RustServerManager Logging Session Started", true, true, ConsoleColor.DarkGray);

            if (!File.Exists("steamcmd.exe"))
            {
                DialogResult prompt = MessageBox.Show("steamcmd.exe was not found!\nDo you want RustServerManager to download it automatically?", "", MessageBoxButtons.YesNo);

                if (prompt == DialogResult.Yes)
                {
                    try
                    {
                        Tools.LogTools.LogEvent("INIT/INFO", "Downloading steamcmd...", false, false, ConsoleColor.Gray);
                        using (var client = new WebClient())
                            client.DownloadFile("https://steamcdn-a.akamaihd.net/client/installer/steamcmd.zip", "steamcmd.zip");

                        Tools.LogTools.LogEvent("INIT/INFO", "Extracting steamcmd...", false, false, ConsoleColor.Gray);
                        ZipFile.ExtractToDirectory("steamcmd.zip", ".\\");
                        File.Delete("steamcmd.zip");
                    }
                    catch (Exception ex)
                    {
                        Tools.LogTools.LogEvent("INIT/ERROR", "An error occurred:\n\n" + ex, true, true, ConsoleColor.Red);
                    }

                    if (File.Exists("steamcmd.exe"))
                        Tools.LogTools.LogEvent("INIT/SUCCESS", "steamcmd installed successfully!", false, true, ConsoleColor.Green);
                }

                if (prompt == DialogResult.No)
                    Environment.Exit(0);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
    }
}
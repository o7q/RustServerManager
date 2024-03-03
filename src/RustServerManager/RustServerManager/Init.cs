using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Windows.Forms;

namespace RustServerManager
{
    internal static class Init
    {
        [STAThread]
        static void Main()
        {
            if (!File.Exists("steamcmd.exe"))
            {
                DialogResult prompt = MessageBox.Show("steamcmd.exe was not found!\nDo you want RustServerManager to download it automatically?", "", MessageBoxButtons.YesNo);

                if (prompt == DialogResult.Yes)
                {
                    try
                    {
                        using (var client = new WebClient())
                            client.DownloadFile("https://steamcdn-a.akamaihd.net/client/installer/steamcmd.zip", "steamcmd.zip");

                        ZipFile.ExtractToDirectory("steamcmd.zip", ".\\");
                        File.Delete("steamcmd.zip");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occured! It can be seen below:\n\n" + ex);
                    }
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
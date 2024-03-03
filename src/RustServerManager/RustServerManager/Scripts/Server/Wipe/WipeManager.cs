using System;
using System.IO;
using System.IO.Compression;

using static RustServerManager.Server.RustDedicated.RustDedicatedProcess;

using static RustServerManager.Global;

namespace RustServerManager.Server.Wipe
{
    public static class WipeManager
    {
        public static void InitiateServerWipe(bool wipeBlueprints, Action completionCallback)
        {
            Tools.LogTools.LogEvent("WIPE-INFO", "Starting server wipe...", false);
            StopRustDedicated(true);

            WipeFiles(wipeBlueprints);
            if (CONFIG.SERVER_SEED_RANDOM_ENABLE)
                CONFIG.SERVER_SEED = GenerateRandomSeed();

            Tools.LogTools.LogEvent("WIPE-INFO", "Server wipe finished!", false);

            completionCallback?.Invoke();
        }

        private static void WipeFiles(bool wipeBlueprints)
        {
            Tools.LogTools.LogEvent("WIPE-INFO", "Wiping server files...", false);
            if (CONFIG.BACKUP_BEFORE_WIPE_ENABLE)
            {
                Directory.CreateDirectory(CONFIG.STEAMCMD_FORCE_INSTALL_DIR + "\\server\\" + CONFIG.SERVER_IDENTITY + "_Backups");

                string zipFilePath = CONFIG.STEAMCMD_FORCE_INSTALL_DIR + "\\server\\" + CONFIG.SERVER_IDENTITY + "_Backups\\" + CONFIG.SERVER_IDENTITY + "_" + DateTime.Now.ToString("M-d-yyyy_hh-mm-ss-tt").ToUpper() + ".zip";
                if (!File.Exists(zipFilePath))
                    ZipFile.CreateFromDirectory(CONFIG.STEAMCMD_FORCE_INSTALL_DIR + "\\server\\" + CONFIG.SERVER_IDENTITY, zipFilePath);
            }

            foreach (string file in Directory.GetFiles(CONFIG.STEAMCMD_FORCE_INSTALL_DIR + "\\server\\" + CONFIG.SERVER_IDENTITY))
            {
                bool shouldDeleteCurrentFile = true;

                if (file.Contains("player.blueprints") && !wipeBlueprints)
                    shouldDeleteCurrentFile = false;

                if (shouldDeleteCurrentFile)
                    File.Delete(file);
            }

            foreach (string directory in Directory.GetDirectories(CONFIG.STEAMCMD_FORCE_INSTALL_DIR + "\\server\\" + CONFIG.SERVER_IDENTITY))
            {
                Directory.Delete(directory, true);
            }
            Tools.LogTools.LogEvent("WIPE-INFO", "Wipe finished!", false);
        }

        public static int GenerateRandomSeed()
        {
            return new Random().Next(0, int.MaxValue);
        }
    }
}
using System;
using System.IO;

using static RustServerManager.Server.Backup.BackupManager;
using static RustServerManager.Server.RustDedicated.RustDedicatedProcess;

using static RustServerManager.Global;

namespace RustServerManager.Server.Wipe
{
    public static class WipeManager
    {
        public static void InitiateServerWipe(bool wipeBlueprints, Action completionCallback)
        {
            Tools.LogTools.LogEvent("WIPE-INFO", "Initiating server wipe...", false);
            StopRustDedicated(true);

            WipeServerFiles(wipeBlueprints);
            if (CONFIG.SERVER_SEED_RANDOM_ENABLE)
                CONFIG.SERVER_SEED = GenerateRandomSeed();

            completionCallback?.Invoke();
        }

        private static void WipeServerFiles(bool wipeBlueprints)
        {
            if (CONFIG.BACKUP_BEFORE_WIPE_ENABLE)
            {
                BackupServer();
            }

            Tools.LogTools.LogEvent("WIPE-INFO", "Wiping server files...", false);

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
            Tools.LogTools.LogEvent("WIPE-INFO", "Server wipe finished!", false);
        }

        public static int GenerateRandomSeed()
        {
            return new Random().Next(0, int.MaxValue);
        }
    }
}
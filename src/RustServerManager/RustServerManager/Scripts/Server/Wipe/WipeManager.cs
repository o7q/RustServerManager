using System;
using System.IO;

using static RustServerManager.Server.Backup.BackupManager;
using static RustServerManager.Server.RustDedicated.RustDedicatedProcess;

using static RustServerManager.Global;

namespace RustServerManager.Server.Wipe
{
    public static class WipeManager
    {
        public static void InitiateServerWipe(bool wipeBlueprints)
        {
            Tools.LogTools.LogEvent("WIPE/INFO", "Initiating server wipe...", false, false, ConsoleColor.Gray);
            StopRustDedicated(true);

            WipeServerFiles(wipeBlueprints);
            if (CONFIG.SERVER_SEED_RANDOM_ENABLE)
                CONFIG.SERVER_SEED = GenerateRandomSeed();
        }

        private static void WipeServerFiles(bool wipeBlueprints)
        {
            if (CONFIG.BACKUP_BEFORE_WIPE_ENABLE)
            {
                BackupServer();
            }

            Tools.LogTools.LogEvent("WIPE/INFO", "Wiping server files...", false, false, ConsoleColor.Gray);

            string baseDirectory = CONFIG.STEAMCMD_FORCE_INSTALL_DIR + "\\server\\" + CONFIG.SERVER_IDENTITY;

            if (!Directory.Exists(baseDirectory))
            {
                Tools.LogTools.LogEvent("WIPE/ERROR", "Base directory (" + baseDirectory + ") does not exist! Aborting wipe...", true, true, ConsoleColor.Red);
                return;
            }

            foreach (string file in Directory.GetFiles(baseDirectory))
            {
                bool shouldDeleteCurrentFile = true;

                if (file.Contains("player.blueprints") && !wipeBlueprints)
                    shouldDeleteCurrentFile = false;

                if (shouldDeleteCurrentFile)
                    File.Delete(file);
            }

            foreach (string directory in Directory.GetDirectories(baseDirectory))
            {
                Directory.Delete(directory, true);
            }
            Tools.LogTools.LogEvent("WIPE/SUCCESS", "Server wipe finished!", false, false, ConsoleColor.Green);
        }

        public static int GenerateRandomSeed()
        {
            return new Random().Next(0, int.MaxValue);
        }
    }
}
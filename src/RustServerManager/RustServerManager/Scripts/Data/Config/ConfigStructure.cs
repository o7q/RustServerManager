using System;

namespace RustServerManager.Data.Config
{
    public class ConfigStructure
    {
        public struct ConfigBase
        {
            public string STEAMCMD_FORCE_INSTALL_DIR;

            public string SERVER_IDENTITY;
            public int SERVER_SEED;
            public bool SERVER_SEED_RANDOM_ENABLE;
            public string SERVER_ARGUMENTS;

            public int WIPE_TIME_HOUR;
            public int WIPE_TIME_MINUTE;
            public string WIPE_TIME_IDENTIFIER;

            public bool WIPE_TIME_START_FROM_SUNDAY;

            public string WIPE_TIME_INTERVAL;
            public DateTime WIPE_DATETIME;
            public bool WIPE_DATETIME_SHOULD_UPDATE;

            public string FORCEWIPE_INTERVAL;
            public DateTime FORCEWIPE_DATETIME;

            public bool AUTO_RESTART_ENABLE;
            public int AUTO_RESTART_TIME_HOUR;
            public int AUTO_RESTART_TIME_MINUTE;
            public string AUTO_RESTART_TIME_IDENTIFIER;

            public bool AUTO_RESTART_ON_CRASH_ENABLE;

            public bool BACKUP_BEFORE_WIPE_ENABLE;
            public bool BACKUP_ON_RESTART_ENABLE;

            public bool DISPLAY_CONSOLE_ENABLE;

        }
    }
}
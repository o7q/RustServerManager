using System;
using System.IO;
using System.Text;

using static RustServerManager.Tools.StringTools;
using static RustServerManager.Data.Config.ConfigStructure;

namespace RustServerManager.Data.Config
{
    public static class ConfigManager
    {
        // this will convert the string to base64 to prevent the config reader from breaking
        // such as if the user happened to use a special split character such as '¶' or 'Ԯ' somewhere in the configuration
        private static bool preventUnsafeConfigStrings = true;

        public static void WriteConfig(ConfigBase queueItem, string location)
        {
            Tools.LogTools.LogEvent("CONFIG/INFO", "Attempting to write config...", false, false, ConsoleColor.DarkGray);
            var sb = new StringBuilder();
            foreach (var field in typeof(ConfigBase).GetFields())
            {
                object value = field.GetValue(queueItem);
                if (value != null)
                    sb.Append(field.Name + '¶' + (preventUnsafeConfigStrings ? EncodeString(value.ToString()) : value.ToString()));
                sb.Append('Ԯ');
            }
            sb.Length--;
            File.WriteAllText(location, sb.ToString());
        }

        public static ConfigBase ReadConfig(string location)
        {
            Tools.LogTools.LogEvent("CONFIG/INFO", "Attempting to read config...", false, false, ConsoleColor.DarkGray);
            ConfigBase config = new ConfigBase();

            string configRaw = File.ReadAllText(location);
            string[] configSetting = configRaw.Split('Ԯ');

            for (int i = 0; i < configSetting.Length; i++)
            {
                string[] configSettingPair = configSetting[i].Split('¶');

                if (preventUnsafeConfigStrings)
                    configSettingPair[1] = DecodeString(configSettingPair[1]);

                switch (configSettingPair[0])
                {
                    case "STEAMCMD_FORCE_INSTALL_DIR": config.STEAMCMD_FORCE_INSTALL_DIR = configSettingPair[1]; break;

                    case "SERVER_IDENTITY": config.SERVER_IDENTITY = configSettingPair[1]; break;
                    case "SERVER_SEED": config.SERVER_SEED = int.Parse(configSettingPair[1]); break;
                    case "SERVER_SEED_RANDOM_ENABLE": config.SERVER_SEED_RANDOM_ENABLE = bool.Parse(configSettingPair[1]); break;
                    case "SERVER_ARGUMENTS": config.SERVER_ARGUMENTS = configSettingPair[1]; break;

                    case "WIPE_TIME_HOUR": config.WIPE_TIME_HOUR = int.Parse(configSettingPair[1]); break;
                    case "WIPE_TIME_MINUTE": config.WIPE_TIME_MINUTE = int.Parse(configSettingPair[1]); break;
                    case "WIPE_TIME_IDENTIFIER": config.WIPE_TIME_IDENTIFIER = configSettingPair[1]; break;

                    case "WIPE_TIME_START_FROM_SUNDAY": config.WIPE_TIME_START_FROM_SUNDAY = bool.Parse(configSettingPair[1]); break;

                    case "WIPE_TIME_INTERVAL": config.WIPE_TIME_INTERVAL = configSettingPair[1]; break;
                    case "WIPE_DATETIME": config.WIPE_DATETIME = DateTime.Parse(configSettingPair[1]); break;
                    case "WIPE_DATETIME_SHOULD_UPDATE": config.WIPE_DATETIME_SHOULD_UPDATE = bool.Parse(configSettingPair[1]); break;

                    case "FORCEWIPE_INTERVAL": config.FORCEWIPE_INTERVAL = configSettingPair[1]; break;
                    case "FORCEWIPE_DATETIME": config.FORCEWIPE_DATETIME = DateTime.Parse(configSettingPair[1]); break;

                    case "AUTO_RESTART_ENABLE": config.AUTO_RESTART_ENABLE = bool.Parse(configSettingPair[1]); break;
                    case "AUTO_RESTART_TIME_HOUR": config.AUTO_RESTART_TIME_HOUR = int.Parse(configSettingPair[1]); break;
                    case "AUTO_RESTART_TIME_MINUTE": config.AUTO_RESTART_TIME_MINUTE = int.Parse(configSettingPair[1]); break;
                    case "AUTO_RESTART_TIME_IDENTIFIER": config.AUTO_RESTART_TIME_IDENTIFIER = configSettingPair[1]; break;

                    case "AUTO_RESTART_ON_CRASH_ENABLE": config.AUTO_RESTART_ON_CRASH_ENABLE = bool.Parse(configSettingPair[1]); break;

                    case "BACKUP_BEFORE_WIPE_ENABLE": config.BACKUP_BEFORE_WIPE_ENABLE = bool.Parse(configSettingPair[1]); break;
                    case "BACKUP_ON_RESTART_ENABLE": config.BACKUP_ON_RESTART_ENABLE = bool.Parse(configSettingPair[1]); break;

                    case "DISPLAY_CONSOLE_ENABLE": config.DISPLAY_CONSOLE_ENABLE = bool.Parse(configSettingPair[1]); break;
                }
            }

            return config;
        }
    }
}
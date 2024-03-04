using System;

using static RustServerManager.Data.Config.ConfigStructure;

namespace RustServerManager
{
    public static class Global
    {
        public static string VERSION = "v1.0.0";

        public static ConfigBase CONFIG = new ConfigBase();
        public static DateTime LOG_DATETIME = new DateTime();
        public static bool SERVER_ALLOWED_TO_AUTO_CRASH_RESTART = false;
    }
}
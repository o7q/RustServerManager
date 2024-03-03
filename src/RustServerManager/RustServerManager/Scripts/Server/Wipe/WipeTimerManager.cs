using System;

using static RustServerManager.Server.Wipe.WipeManager;
using static RustServerManager.Server.RustDedicated.RustDedicatedProcess;

using static RustServerManager.Global;

namespace RustServerManager.Server.Wipe
{
    public static class WipeTimerManager
    {
        private static System.Timers.Timer timer = new System.Timers.Timer(1000);

        private static bool doWipe = false;

        private static bool allowWipeTimerScan = false;

        public static void InitiateWipeTimer()
        {
            // create a timer with the delay duration
            timer.Elapsed += (sender, e) =>
            {
                // debug console writeline
                /*Console.WriteLine("TIMER ELAPSED | allowWipeTimerScan: " + allowWipeTimerScan);*/

                if (allowWipeTimerScan)
                {
                    // calculate the delay duration until the target date and time
                    TimeSpan timeUntilWipe = CONFIG.WIPE_DATETIME - DateTime.Now;
                    TimeSpan timeUntilForceWipe = CONFIG.FORCEWIPE_DATETIME - DateTime.Now;

                    bool wipeBlueprints = false;

                    if (timeUntilWipe.TotalSeconds < 0)
                    {
                        Tools.LogTools.LogEvent("WIPE/INFO", "Wipe event triggered", false, false, ConsoleColor.Gray);
                        doWipe = true;
                    }
                    if (timeUntilForceWipe.TotalSeconds < 0)
                    {
                        Tools.LogTools.LogEvent("WIPE/INFO", "Forcewipe event triggered", false, false, ConsoleColor.Gray);
                        doWipe = true;
                        wipeBlueprints = true;
                    }

                    if (doWipe)
                    {
                        doWipe = false;
                        allowWipeTimerScan = false;

                        if (CONFIG.FORCEWIPE_INTERVAL == "EVERYWIPE")
                        {
                            wipeBlueprints = true;
                        }

                        InitiateServerWipe(wipeBlueprints);
                        CONFIG.WIPE_DATETIME_SHOULD_UPDATE = true;
                        StartRustDedicated();
                    }
                }
            };
            timer.Enabled = true;
        }

        public static void EnableWipeTimer()
        {
            Tools.LogTools.LogEvent("WIPE/INFO", "Enabling wipe timer...", false, false, ConsoleColor.Gray);

            if (CONFIG.WIPE_DATETIME_SHOULD_UPDATE)
                UpdateNextWipeDate();

            CONFIG.WIPE_DATETIME_SHOULD_UPDATE = false;

            allowWipeTimerScan = true;
        }

        public static void DisableWipeTimer()
        {
            Tools.LogTools.LogEvent("WIPE/INFO", "Disabling wipe timer...", false, false, ConsoleColor.Gray);
            allowWipeTimerScan = false;
        }

        private static void UpdateNextWipeDate()
        {
            // DEBUG TEST CODE
            /*CONFIG.WIPE_DATETIME = DateTime.Now.Add(TimeSpan.FromSeconds(20));
            CONFIG.FORCEWIPE_DATETIME = DateTime.Now.Add(TimeSpan.FromSeconds(20));

            Console.WriteLine("WIPE: " + CONFIG.WIPE_DATETIME);
            Console.WriteLine("FORCEWIPE: " + CONFIG.FORCEWIPE_DATETIME);

            return;*/

            // get current date
            DateTime currentDate = DateTime.Today;

            if (CONFIG.WIPE_TIME_START_FROM_SUNDAY)
            {
                // calculate the difference in days between the current day and previous sunday
                int daysUntilTargetDay = ((int)DayOfWeek.Sunday - (int)currentDate.DayOfWeek + 7) % 7;

                // subtract the difference to find the previous sunday
                currentDate = currentDate.AddDays(-daysUntilTargetDay);
            }

            DateTime nextServerWipeDate = currentDate;

            switch (CONFIG.WIPE_TIME_INTERVAL)
            {
                case "WEEKLY":
                    nextServerWipeDate = currentDate.AddDays(7);
                    break;

                case "BIWEEKLY":
                    nextServerWipeDate = currentDate.AddDays(14);
                    break;

                case "MONTHLY":
                    nextServerWipeDate = currentDate.AddMonths(1);
                    break;
            }

            // find the next specified day
            nextServerWipeDate = DetermineNextOccurenceOfDay(nextServerWipeDate, DayOfWeek.Thursday);

            nextServerWipeDate = nextServerWipeDate.AddHours(CONFIG.WIPE_TIME_HOUR);

            if (CONFIG.WIPE_TIME_IDENTIFIER == "PM")
                nextServerWipeDate = nextServerWipeDate.AddHours(12);

            nextServerWipeDate = nextServerWipeDate.AddMinutes(CONFIG.WIPE_TIME_MINUTE);

            if (nextServerWipeDate == null)
                return;

            CONFIG.WIPE_DATETIME = nextServerWipeDate;

            switch (CONFIG.FORCEWIPE_INTERVAL)
            {
                case "FORCEWIPE":
                    DateTime currentDateNextMonth = currentDate.AddMonths(1);
                    DateTime firstDayOfMonth = new DateTime(currentDateNextMonth.Year, currentDateNextMonth.Month, 1);
                    DateTime firstThursdayOfMonth = DetermineNextOccurenceOfDay(firstDayOfMonth, DayOfWeek.Thursday);
                    firstThursdayOfMonth = firstThursdayOfMonth.AddHours(14);
                    CONFIG.FORCEWIPE_DATETIME = firstThursdayOfMonth;
                    break;

                case "EVERYWIPE":
                    CONFIG.FORCEWIPE_DATETIME = nextServerWipeDate;
                    break;
            }

            Tools.LogTools.LogEvent("WIPE/INFO", "Set new wipe date to: " + CONFIG.WIPE_DATETIME, false, false, ConsoleColor.Cyan);
            Tools.LogTools.LogEvent("WIPE/INFO", "Set new forcewipe date to: " + CONFIG.FORCEWIPE_DATETIME, false, false, ConsoleColor.Cyan);
        }

        private static DateTime DetermineNextOccurenceOfDay(DateTime date, DayOfWeek dayOfWeek)
        {
            while (date.DayOfWeek != dayOfWeek)
            {
                date = date.AddDays(1);
            }
            return date;
        }
    }
}
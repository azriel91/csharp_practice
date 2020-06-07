using System;

namespace TimeAddLibrary
{
    public static class TimeExtensions
    {
        public static TimeSpan Secs(this Int32 seconds) =>
            new TimeSpan(0, 0, seconds);

        public static TimeSpan Mins(this Int32 minutes) =>
            new TimeSpan(0, minutes, 0);

        public static TimeSpan Hours(this Int32 hours) =>
            new TimeSpan(hours, 0, 0);

        public static String HumanReadable(this TimeSpan timeSpan)
        {
            return $"{timeSpan.Hours} hours {timeSpan.Minutes} minutes " +
            "{timeSpan.Seconds} seconds";
        }
    }
}

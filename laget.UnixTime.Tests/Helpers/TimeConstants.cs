using System;

namespace laget.UnixTime.Tests.Helpers
{
    public static class TimeConstants
    {
        public static long OneMinute => 60;
        public static long OneHour => 3600;
        public static long OneDay => 86400;
        public static long OneYear => 31556026;

        public static DateTime DateTimeMaxValue => DateTime.MaxValue;
        public static DateTime DateTimeMinValue => DateTime.MinValue;
        public static long LongMaxValue => long.MaxValue;
        public static long LongMinValue => long.MinValue;
    }
}

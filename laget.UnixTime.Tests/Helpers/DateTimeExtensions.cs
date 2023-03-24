using System;

namespace laget.UnixTime.Tests.Helpers
{
    internal static class DateTimeExtensions
    {
        public static DateTime BeginningOfMinute(this DateTime dateTime)
        {
            return new DateTime(
                dateTime.Year,
                dateTime.Month,
                dateTime.Day,
                dateTime.Hour,
                dateTime.Minute,
                0,
                0);
        }
    }
}

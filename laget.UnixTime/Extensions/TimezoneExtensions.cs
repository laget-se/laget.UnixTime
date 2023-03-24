using System;

namespace laget.UnixTime.Extensions
{
    public static class TimezoneExtensions
    {
        public static Epoch ToTimezone(this Epoch epoch, TimeZoneInfo timeZoneInfo)
        {
            var datetime = epoch.DateTime;
            //TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time"));
            var converted = TimeZoneInfo.ConvertTime(datetime, timeZoneInfo);

            return converted.ToEpoch();
        }
    }
}

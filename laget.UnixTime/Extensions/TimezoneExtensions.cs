using System;

namespace laget.UnixTime.Extensions
{
    public static class TimezoneExtensions
    {
        public static Epoch ToTimezone(this Epoch epoch, TimeZoneInfo timeZoneInfo)
        {
            var datetime = epoch.DateTime;
            var converted = TimeZoneInfo.ConvertTime(datetime, timeZoneInfo);

            return converted.ToEpoch();
        }
    }
}

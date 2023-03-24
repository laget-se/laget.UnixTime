using System;

namespace laget.UnixTime.Extensions
{
    public static class DateTimeExtensions
    {
        public static Epoch ToEpoch(this DateTime dateTime)
        {
            if (dateTime.Kind == DateTimeKind.Utc)
                return new Epoch(dateTime);

            return new Epoch(dateTime.ToUniversalTime());
        }

        public static Epoch ToEpoch(this DateTime datetime, DateTimeKind kind)
        {
            switch (kind)
            {
                case DateTimeKind.Local:
                case DateTimeKind.Unspecified:
                    return datetime.Kind == DateTimeKind.Local ? new Epoch(datetime) : new Epoch(datetime.ToLocalTime());
                default:
                case DateTimeKind.Utc:
                    return datetime.Kind == DateTimeKind.Utc ? new Epoch(datetime) : new Epoch(datetime.ToUniversalTime());
            }
        }
    }
}

using System;

namespace laget.UnixTime.Providers
{
    public interface ITimeProvider
    {
        Epoch Now();
        Epoch Zero();
    }

    public class TimeProvider : ITimeProvider
    {
        private readonly TimeZoneInfo _timeZoneInfo;

        public TimeProvider(TimeZoneInfo timeZoneInfo)
        {
            _timeZoneInfo = timeZoneInfo;
        }

        public TimeProvider(string timeZone)
        {
            var tz = TimeZoneInfo.FindSystemTimeZoneById(timeZone);
            _timeZoneInfo = tz;
        }

        public Epoch Now()
        {
            var datetime = Epoch.Now.DateTime;
            var converted = TimeZoneInfo.ConvertTime(datetime, _timeZoneInfo);

            return new Epoch(converted);
        }

        public Epoch Zero()
        {
            return Epoch.Zero;
        }

        public TimeZoneInfo TimeZoneInfo => _timeZoneInfo;

        public static TimeProvider From(TimeZoneInfo timeZoneInfo)
        {
            return new TimeProvider(timeZoneInfo);
        }

        public static TimeProvider System => new TimeProvider(TimeZoneInfo.Local);

        public static TimeProvider Utc => new TimeProvider(TimeZoneInfo.Utc);
    }
}

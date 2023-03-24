using System;

namespace laget.UnixTime.Extensions
{
    public static class EpochExtensions
    {
        public static Epoch BeginningOfMinute(this Epoch epoch)
        {
            var datetime = epoch.ToDateTime();

            return new Epoch(new DateTime(
                    datetime.Year,
                    datetime.Month,
                    datetime.Day,
                    datetime.Hour,
                    datetime.Minute,
                    0,
                    0));
        }

        public static Epoch EndOfMinute(this Epoch epoch)
        {
            var datetime = epoch.ToDateTime();

            return new Epoch(new DateTime(
                    datetime.Year,
                    datetime.Month,
                    datetime.Day,
                    datetime.Hour,
                    datetime.Minute,
                    59,
                    999));
        }

        public static Epoch BeginningOfHour(this Epoch epoch)
        {
            var datetime = epoch.ToDateTime();

            return new Epoch(new DateTime(
                    datetime.Year,
                    datetime.Month,
                    datetime.Day,
                    datetime.Hour,
                    0,
                    0,
                    0));
        }

        public static Epoch EndOfHour(this Epoch epoch)
        {
            var datetime = epoch.ToDateTime();

            return new Epoch(new DateTime(
                    datetime.Year,
                    datetime.Month,
                    datetime.Day,
                    datetime.Hour,
                    59,
                    59,
                    999));
        }

        public static Epoch BeginningOfDay(this Epoch epoch)
        {
            var datetime = epoch.ToDateTime();

            return new Epoch(new DateTime(
                    datetime.Year,
                    datetime.Month,
                    datetime.Day,
                    0,
                    0,
                    0,
                    0));
        }

        public static Epoch EndOfDay(this Epoch epoch)
        {
            var datetime = epoch.ToDateTime();

            return new Epoch(new DateTime(
                    datetime.Year,
                    datetime.Month,
                    datetime.Day,
                    23,
                    59,
                    59,
                    999));
        }

        public static Epoch BeginningOfMonth(this Epoch epoch)
        {
            var datetime = epoch.ToDateTime();

            return new Epoch(new DateTime(
                    datetime.Year,
                    datetime.Month,
                    1,
                    0,
                    0,
                    0,
                    0));
        }

        public static Epoch EndOfMonth(this Epoch epoch)
        {
            var datetime = epoch.ToDateTime();

            return new Epoch(new DateTime(
                    datetime.Year,
                    datetime.Month,
                    DateTime.DaysInMonth(datetime.Year, datetime.Month),
                    23,
                    59,
                    59,
                    999));
        }

        public static Epoch BeginningOfYear(this Epoch epoch)
        {
            var datetime = epoch.ToDateTime();

            return new Epoch(new DateTime(
                    datetime.Year,
                    1,
                    1,
                    0,
                    0,
                    0,
                    0));
        }

        public static Epoch EndOfYear(this Epoch epoch)
        {
            var original = epoch.ToDateTime();

            return new Epoch(new DateTime(
                    original.Year,
                    12,
                    31,
                    23,
                    59,
                    59,
                    999));
        }

        public static DateTime ToDateTime(this Epoch epoch) =>
            new DateTime(1970, 01, 01).AddSeconds(epoch.Value);
    }
}

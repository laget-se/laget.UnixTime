using System;

namespace laget.UnixTime.Extensions
{
    public static class EpochExtensions
    {
        /// <summary>
        /// Returns a new `Epoch` that adds the specified TimeSpan to the
        /// value of this instance.
        /// </summary>
        /// <param name="epoch"></param>
        /// <param name="value"></param>
        /// <returns>
        /// An object whose value is the sum of the date and time
        /// represented by this instance and the time interval represented
        /// by value.
        /// </returns>
        public static Epoch Add(this Epoch epoch, TimeSpan value)
        {
            var datetime = epoch
                .ToDateTime()
                .Add(value);

            return new Epoch(datetime);
        }

        /// <summary>
        /// Returns a new `Epoch` that adds the specified number of seconds
        /// to the value of this instance.
        /// </summary>
        /// <param name="epoch"></param>
        /// <param name="value"></param>
        /// <returns>
        /// An object whose value is the sum of the date and time
        /// represented by this instance and the number of seconds represented
        /// by value.
        /// </returns>
        public static Epoch AddSeconds(this Epoch epoch, double value)
        {
            var datetime = epoch
                .ToDateTime()
                .AddSeconds(value);

            return new Epoch(datetime);
        }

        /// <summary>
        /// Returns a new `Epoch` that adds the specified number of minutes
        /// to the value of this instance.
        /// </summary>
        /// <param name="epoch"></param>
        /// <param name="value"></param>
        /// <returns>
        /// An object whose value is the sum of the date and time
        /// represented by this instance and the number of minutes represented
        /// by value.
        /// </returns>
        public static Epoch AddMinutes(this Epoch epoch, double value)
        {
            var datetime = epoch
                .ToDateTime()
                .AddMinutes(value);

            return new Epoch(datetime);
        }

        /// <summary>
        /// Returns a new `Epoch` that adds the specified number of hours
        /// to the value of this instance.
        /// </summary>
        /// <param name="epoch"></param>
        /// <param name="value"></param>
        /// <returns>
        /// An object whose value is the sum of the date and time
        /// represented by this instance and the number of hours represented
        /// by value.
        /// </returns>
        public static Epoch AddHours(this Epoch epoch, double value)
        {
            var datetime = epoch
                .ToDateTime()
                .AddHours(value);

            return new Epoch(datetime);
        }

        /// <summary>
        /// Returns a new `Epoch` that adds the specified number of days
        /// to the value of this instance.
        /// </summary>
        /// <param name="epoch"></param>
        /// <param name="value"></param>
        /// <returns>
        /// An object whose value is the sum of the date and time
        /// represented by this instance and the number of days represented
        /// by value.
        /// </returns>
        public static Epoch AddDays(this Epoch epoch, double value)
        {
            var datetime = epoch
                .ToDateTime()
                .AddDays(value);

            return new Epoch(datetime);
        }

        /// <summary>
        /// Returns a new `Epoch` that adds the specified number of months
        /// to the value of this instance.
        /// </summary>
        /// <param name="epoch"></param>
        /// <param name="value"></param>
        /// <returns>
        /// An object whose value is the sum of the date and time
        /// represented by this instance and the number of months represented
        /// by value.
        /// </returns>
        public static Epoch AddMonths(this Epoch epoch, int value)
        {
            var datetime = epoch
                .ToDateTime()
                .AddMonths(value);

            return new Epoch(datetime);
        }


        /// <summary>
        /// Returns a new `Epoch` that adds the specified number of years
        /// to the value of this instance.
        /// </summary>
        /// <param name="epoch"></param>
        /// <param name="value"></param>
        /// <returns>
        /// An object whose value is the sum of the date and time
        /// represented by this instance and the number of years represented
        /// by value.
        /// </returns>
        public static Epoch AddYears(this Epoch epoch, int value)
        {
            var datetime = epoch
                .ToDateTime()
                .AddYears(value);

            return new Epoch(datetime);
        }

        /// <summary>
        /// This method will return the original Epoch but with the timespan adjusted
        /// to the beginning of the current minute.
        /// </summary>
        /// <param name="epoch"></param>
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

        /// <summary>
        /// This method will return the original Epoch but with the timespan adjusted
        /// to the end of the current minute.
        /// </summary>
        /// <param name="epoch"></param>
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

        /// <summary>
        /// This method will return the original Epoch but with the timespan adjusted
        /// to the beginning of the current hour.
        /// </summary>
        /// <param name="epoch"></param>
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

        /// <summary>
        /// This method will return the original Epoch but with the timespan adjusted
        /// to the end of the current hour.
        /// </summary>
        /// <param name="epoch"></param>
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

        /// <summary>
        /// This method will return the original Epoch but with the timespan adjusted
        /// to the beginning of the current day.
        /// </summary>
        /// <param name="epoch"></param>
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

        /// <summary>
        /// This method will return the original Epoch but with the timespan adjusted
        /// to the end of the current day.
        /// </summary>
        /// <param name="epoch"></param>
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

        /// <summary>
        /// This method will return the original Epoch but with the timespan adjusted
        /// to the beginning of the current month.
        /// </summary>
        /// <param name="epoch"></param>
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

        /// <summary>
        /// This method will return the original Epoch but with the timespan adjusted
        /// to the end of the current month.
        /// </summary>
        /// <param name="epoch"></param>
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

        /// <summary>
        /// This method will return the original Epoch but with the timespan adjusted
        /// to the beginning of the current year.
        /// </summary>
        /// <param name="epoch"></param>
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

        /// <summary>
        /// This method will return the original Epoch but with the timespan adjusted
        /// to the end of the current year.
        /// </summary>
        /// <param name="epoch"></param>
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

        /// <summary>
        /// This method will convert the provided Epoch to a DateTime.
        /// </summary>
        /// <param name="epoch"></param>
        /// <returns></returns>
        public static DateTime ToDateTime(this Epoch epoch) =>
            new DateTime(1970, 01, 01).AddSeconds(epoch.Value);

        /// <summary>
        /// This method will return the current Epoch converted to a
        /// time zone specific adjusted Epoch.
        /// </summary>
        /// <param name="epoch"></param>
        /// <param name="timeZoneInfo"></param>
        public static Epoch InTimezone(this Epoch epoch, TimeZoneInfo timeZoneInfo)
        {
            var datetime = epoch.DateTime;
            var converted = TimeZoneInfo.ConvertTime(datetime, timeZoneInfo);

            return new Epoch(converted);
        }
    }
}

using laget.UnixTime.Extensions;
using laget.UnixTime.Tests.Helpers;
using System;
using Xunit;

namespace laget.UnixTime.Tests.Extensions
{
    [UseCulture("sv-SE")]
    public class EpochExtensionsTests
    {
        [Fact]
        public void ShouldBeAbleToAddTimeSpan()
        {
            var epoch = new Epoch(new DateTime(1970, 01, 02, 12, 30, 45));
            var timespan = new TimeSpan(1, 1, 1, 1);

            var expected = new Epoch(new DateTime(1970, 01, 03, 13, 31, 46));
            var actual = epoch.Add(timespan);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldBeAbleToAddSeconds()
        {
            var epoch = new Epoch(new DateTime(1970, 01, 02, 12, 30, 45));

            var expected = new Epoch(new DateTime(1970, 01, 02, 12, 30, 55));
            var actual = epoch.AddSeconds(10);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldBeAbleToAddMinutes()
        {
            var epoch = new Epoch(new DateTime(1970, 01, 02, 12, 30, 45));

            var expected = new Epoch(new DateTime(1970, 01, 02, 12, 40, 45));
            var actual = epoch.AddMinutes(10);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldBeAbleToAddHours()
        {
            var epoch = new Epoch(new DateTime(1970, 01, 02, 12, 30, 45));

            var expected = new Epoch(new DateTime(1970, 01, 02, 14, 30, 45));
            var actual = epoch.AddHours(2);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldBeAbleToAddDays()
        {
            var epoch = new Epoch(new DateTime(1970, 01, 02, 12, 30, 45));

            var expected = new Epoch(new DateTime(1970, 01, 04, 12, 30, 45));
            var actual = epoch.AddDays(2);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldBeAbleToAddMonths()
        {
            var epoch = new Epoch(new DateTime(1970, 01, 02, 12, 30, 45));

            var expected = new Epoch(new DateTime(1970, 02, 02, 12, 30, 45));
            var actual = epoch.AddMonths(1);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldBeAbleToAddYears()
        {
            var epoch = new Epoch(new DateTime(1970, 01, 02, 12, 30, 45));

            var expected = new Epoch(new DateTime(1971, 01, 02, 12, 30, 45));
            var actual = epoch.AddYears(1);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldBeAbleToAddYearsMonthsDaysHoursMinutesAndSeconds()
        {
            var epoch = new Epoch(new DateTime(1970, 01, 01, 0, 0, 0));

            var expected = new Epoch(new DateTime(1971, 02, 02, 1, 10, 10));
            var actual = epoch.AddYears(1).AddMonths(1).AddDays(1).AddHours(1).AddMinutes(10).AddSeconds(10);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldChangeTimeToBeginningOfMinute()
        {
            var epoch = new Epoch(new DateTime(1970, 01, 01, 12, 30, 45));

            var expected = new Epoch(new DateTime(1970, 01, 01, 12, 30, 0));
            var actual = epoch.BeginningOfMinute();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldChangeTimeToÉndOfMinute()
        {
            var epoch = new Epoch(new DateTime(1970, 01, 01, 12, 30, 45));

            var expected = new Epoch(new DateTime(1970, 01, 01, 12, 30, 59));
            var actual = epoch.EndOfMinute();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldChangeTimeToBeginningOfHour()
        {
            var epoch = new Epoch(new DateTime(1970, 01, 01, 12, 30, 45));

            var expected = new Epoch(new DateTime(1970, 01, 01, 12, 0, 0));
            var actual = epoch.BeginningOfHour();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldChangeTimeToÉndOfHour()
        {
            var epoch = new Epoch(new DateTime(1970, 01, 01, 12, 30, 45));

            var expected = new Epoch(new DateTime(1970, 01, 01, 12, 59, 59));
            var actual = epoch.EndOfHour();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldChangeTimeToBeginningOfDay()
        {
            var epoch = new Epoch(new DateTime(1970, 01, 01, 12, 30, 45));

            var expected = new Epoch(new DateTime(1970, 01, 01, 0, 0, 0));
            var actual = epoch.BeginningOfDay();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldChangeTimeToÉndOfDay()
        {
            var epoch = new Epoch(new DateTime(1970, 01, 01, 12, 30, 45));

            var expected = new Epoch(new DateTime(1970, 01, 01, 23, 59, 59));
            var actual = epoch.EndOfDay();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldChangeTimeToBeginningOfMonth()
        {
            var epoch = new Epoch(new DateTime(1970, 01, 14, 12, 30, 45));

            var expected = new Epoch(new DateTime(1970, 01, 01, 0, 0, 0));
            var actual = epoch.BeginningOfMonth();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldChangeTimeToÉndOfMonth()
        {
            var epoch = new Epoch(new DateTime(1970, 01, 02, 12, 30, 45));

            var expected = new Epoch(new DateTime(1970, 01, 31, 23, 59, 59));
            var actual = epoch.EndOfMonth();

            Assert.Equal(expected, actual);
        }


        [Fact]
        public void ShouldChangeTimeToBeginningOfYear()
        {
            var epoch = new Epoch(new DateTime(1970, 01, 14, 12, 30, 45));

            var expected = new Epoch(new DateTime(1970, 01, 01, 0, 0, 0));
            var actual = epoch.BeginningOfYear();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldChangeTimeToÉndOfYear()
        {
            var epoch = new Epoch(new DateTime(1970, 01, 02, 12, 30, 45));

            var expected = new Epoch(new DateTime(1970, 12, 31, 23, 59, 59));
            var actual = epoch.EndOfYear();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldConvertEpochToDateTime()
        {
            var epoch = new Epoch(new DateTime(1970, 01, 02, 12, 30, 45));

            var expected = new DateTime(1970, 01, 02, 12, 30, 45);
            var actual = epoch.ToDateTime();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldConvertEpochToSpecifiedTimeZone()
        {
            var epoch = new Epoch(new DateTime(1970, 01, 02, 12, 30, 45));

            const int expected = 135045;
            var timezone = TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time");
            var actual = epoch.InTimezone(timezone);

            Assert.Equal(expected, actual);
        }
    }
}
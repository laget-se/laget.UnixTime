using laget.UnixTime.Extensions;
using laget.UnixTime.Tests.Helpers;
using System;
using Xunit;

namespace laget.UnixTime.Tests
{
    public class EpochTests
    {
        [Fact]
        public void ShouldCreateEpochFromLong()
        {
            Assert.Equal(0, (new Epoch()).Value);
            Assert.Equal(1640995200, (new Epoch((long)1640995200)).Value);
            Assert.Equal(1672444800, (new Epoch((long)1672444800)).Value);
        }

        [Fact]
        public void ShouldCreateEpochFromDateTime()
        {
            Assert.Equal(0, (new Epoch(new DateTime(1970, 01, 01))).Value);
            Assert.Equal(1640995200, (new Epoch(new DateTime(2022, 01, 01))).Value);
            Assert.Equal(1672444800, (new Epoch(new DateTime(2022, 12, 31))).Value);
        }

        [Fact]
        public void ShouldBeAbleToUseOperators()
        {
            var beginning = new Epoch();
            var end = new Epoch(new DateTime(2038, 1, 19));

            Assert.True(beginning < end);
            Assert.True(beginning <= end);
            Assert.False(beginning > end);
            Assert.False(beginning >= end);
            Assert.True(beginning == new Epoch());
            Assert.Equal(beginning, new Epoch());
            Assert.True(beginning.Equals(new Epoch()));
            Assert.False(beginning.Equals(end));
            Assert.True(beginning != end);

            Assert.True(end > beginning);
            Assert.True(end >= beginning);
            Assert.False(end < beginning);
            Assert.False(end <= beginning);
            Assert.False(end == beginning);
            Assert.False(end.Equals(new Epoch()));
            Assert.True(end != beginning);

            Assert.True(new Epoch() == new Epoch());
            Assert.Equal(new Epoch(), new Epoch());
            Assert.True(new Epoch() != end);
            Assert.False(new Epoch() >= end);
        }

        [Fact]
        public void ShouldBeAbleToHandleMaxValue()
        {
            Assert.Equal(new DateTime(9999, 12, 31, 23, 59, 59), new Epoch(TimeConstants.DateTimeMaxValue).DateTime);

            Assert.Equal(TimeConstants.LongMaxValue, new Epoch(TimeConstants.LongMaxValue).Value);
            Assert.Throws<ArgumentOutOfRangeException>(() => new Epoch(TimeConstants.LongMaxValue).DateTime);
        }

        [Fact]
        public void ShouldBeAbleToHandleMinValue()
        {
            Assert.Equal(new DateTime(1, 1, 1, 0, 0, 0), new Epoch(TimeConstants.DateTimeMinValue).DateTime);

            Assert.Equal(TimeConstants.LongMinValue, new Epoch(TimeConstants.LongMinValue).Value);
            Assert.Throws<ArgumentOutOfRangeException>(() => new Epoch(TimeConstants.LongMinValue).DateTime);
        }

        [Fact]
        public void ShouldBeAbleToAdd()
        {
            var expected = new DateTime(1986, 03, 20, 1, 0, 0);
            var actual = new Epoch(new DateTime(1986, 03, 20, 0, 0, 0)) + TimeConstants.OneHour;

            Assert.Equal(expected, actual.DateTime);
        }

        [Fact]
        public void ShouldBeAbleToSubtract()
        {
            var expected = new DateTime(1986, 03, 20, 1, 0, 0);
            var actual = new Epoch(new DateTime(1986, 03, 20, 2, 0, 0)) - TimeConstants.OneHour;

            Assert.Equal(expected, actual.DateTime);
        }

        [Fact]
        public void ShouldBeAbleToSubtractAndReturnTimeSpan()
        {
            var epoch1 = new Epoch(new DateTime(1986, 03, 20, 12, 0, 0));
            var epoch2 = new Epoch(new DateTime(1986, 03, 19, 10, 59, 0));

            var expected = new TimeSpan(1, 1, 1, 0);
            var actual = (epoch1 - epoch2);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldReturnCorrectEpochWhenCallingNow()
        {
            var epoch = Epoch.Now;

            var expected = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
            var actual = epoch.ToString("yyyy-MM-dd HH:mm:ss");

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldReturnCorrectStringWhenCallingToString()
        {
            var epoch = Epoch.Zero;

            const string expected = "1970-01-01 00:00:00";
            var actual = epoch.ToString("yyyy-MM-dd HH:mm:ss");

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldReturnCorrectStringWhenCallingToStringWithFormat()
        {
            var epoch = Epoch.Zero;

            var expected = epoch.ToDateTime().ToString("yyyy-MM-dd");
            var actual = epoch.ToString("yyyy-MM-dd");

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldReturnLocalEpochTimestamp()
        {
            var datetime = new DateTime(2023, 01, 01, 15, 0, 0, DateTimeKind.Utc);
            var epoch = new Epoch(datetime).ToLocal();

            var expected = new DateTime(2023, 01, 01, 16, 0, 0).ToString("yyyy-MM-dd HH:mm:ss");
            var actual = epoch.DateTime.ToString("yyyy-MM-dd HH:mm:ss");

            Assert.Equal(expected, actual);
        }
    }
}

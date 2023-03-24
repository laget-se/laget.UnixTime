using laget.UnixTime.Extensions;
using System;
using Xunit;

namespace laget.UnixTime.Tests.Extensions
{
    public class EpochExtensionsTests
    {
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
    }
}

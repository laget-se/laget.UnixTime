using laget.UnixTime.Extensions;
using System;
using Xunit;

namespace laget.UnixTime.Tests
{
    public class TimeProviderTests
    {
        [Fact]
        public void ShouldCreateSystemTimeProvider()
        {
            var timeProvider = Providers.TimeProvider.System;

            var expected = TimeZoneInfo.Local;
            var actual = timeProvider.TimeZoneInfo;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldCreateUtcTimeProvider()
        {
            var timeProvider = Providers.TimeProvider.Utc;

            var expected = TimeZoneInfo.Utc;
            var actual = timeProvider.TimeZoneInfo;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldCreateZoneTimeProvider()
        {
            var timezone = TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time");
            var timeProvider = Providers.TimeProvider.From(timezone);

            var expected = TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time");
            var actual = timeProvider.TimeZoneInfo;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldReturnCorrectUtcNow()
        {
            var timeProvider = Providers.TimeProvider.Utc;

            var expected = Epoch.Now;
            var actual = timeProvider.Now();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldReturnCorrectLocalNow()
        {
            var timeProvider = Providers.TimeProvider.System;

            var expected = Epoch.Now.ToLocal();
            var actual = timeProvider.Now();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldConvertEpochToSpecifiedTimeZone()
        {
            var timezone = TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time");
            var timeProvider = Providers.TimeProvider.Timezone(timezone);

            var expected = DateTime.Now.ToEpoch(timezone);
            var actual = timeProvider.Now();

            Assert.Equal(expected, actual);
        }
    }
}
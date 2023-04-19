using laget.UnixTime.Providers;
using System;
using Xunit;

namespace laget.UnixTime.Tests
{
    public class TimeProviderTests
    {
        [Fact]
        public void ShouldCreateSystemTimeProvider()
        {
            var timeProvider = TimeProvider.System;

            var expected = TimeZoneInfo.Local;
            var actual = timeProvider.TimeZoneInfo;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldCreateUtcTimeProvider()
        {
            var timeProvider = TimeProvider.Utc;

            var expected = TimeZoneInfo.Utc;
            var actual = timeProvider.TimeZoneInfo;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldCreateZoneTimeProvider()
        {
            var timeProvider = TimeProvider.Timezone(TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time"));

            var expected = TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time");
            var actual = timeProvider.TimeZoneInfo;

            Assert.Equal(expected, actual);
        }
    }
}
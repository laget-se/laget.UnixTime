using laget.UnixTime.Extensions;
using laget.UnixTime.Tests.Helpers;
using System;
using Xunit;

namespace laget.UnixTime.Tests.Extensions
{
    [UseCulture("sv-SE")]
    public class DateTimeExtensionsTests
    {
        [Fact]
        public void ShouldConvertDateTimeToEpoch()
        {
            var expected = DateTime.UtcNow;
            var actual = DateTime.Now.ToEpoch();

            Assert.Equal(expected.BeginningOfMinute(), actual.DateTime.BeginningOfMinute());
        }

        [Fact]
        public void ShouldConvertDateTimeEpochWithDateTimeKind_Local()
        {
            var expected = DateTime.Now;
            var actual = DateTime.UtcNow.ToEpoch(DateTimeKind.Local);

            Assert.Equal(expected.BeginningOfMinute(), actual.DateTime.BeginningOfMinute());
        }

        [Fact]
        public void ShouldConvertDateTimeEpochWithDateTimeKind_Utc()
        {
            var expected = DateTime.UtcNow;
            var actual = DateTime.Now.ToEpoch(DateTimeKind.Utc);

            Assert.Equal(expected.BeginningOfMinute(), actual.DateTime.BeginningOfMinute());
        }
    }
}

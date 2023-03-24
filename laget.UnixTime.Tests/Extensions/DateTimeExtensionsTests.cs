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
            var expected = new DateTime(1994, 02, 27, 0, 0, 0, DateTimeKind.Utc);
            var actual = new DateTime(1994, 02, 27, 1, 0, 0).ToEpoch();

            Assert.Equal(expected, actual.DateTime);
        }

        [Fact]
        public void ShouldConvertDateTimeEpochWithDateTimeKind_Local()
        {
            var expected = new DateTime(1994, 02, 27, 2, 0, 0, DateTimeKind.Local);
            var actual = new DateTime(1994, 02, 27, 1, 0, 0, DateTimeKind.Utc).ToEpoch(DateTimeKind.Local);

            Assert.Equal(expected, actual.DateTime);
        }

        [Fact]
        public void ShouldConvertDateTimeEpochWithDateTimeKind_Utc()
        {
            var expected = new DateTime(1994, 02, 27, 0, 0, 0, DateTimeKind.Utc);
            var actual = new DateTime(1994, 02, 27, 1, 0, 0, DateTimeKind.Local).ToEpoch(DateTimeKind.Utc);

            Assert.Equal(expected, actual.DateTime);
        }
    }
}

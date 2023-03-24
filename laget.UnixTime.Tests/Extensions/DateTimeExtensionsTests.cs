using laget.UnixTime.Extensions;
using System;
using Xunit;

namespace laget.UnixTime.Tests.Extensions
{
    public class DateTimeExtensionsTests
    {
        [Fact]
        public void ShouldConvertDateTimeToEpoch()
        {
            var datetime = new DateTime(1994, 02, 27);
            var epoch = datetime.ToEpoch();

            Assert.Equal(datetime, epoch.DateTime);
        }
    }
}

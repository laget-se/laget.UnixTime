using laget.UnixTime.Extensions;
using Xunit;

namespace laget.UnixTime.Tests.Extensions
{
    public class IntExtensionsTests
    {
        [Fact]
        public void ShouldConvertLongToEpoch()
        {
            const long @long = (long)762307200;
            var epoch = @long.ToEpoch();

            Assert.Equal(@long, epoch.Value);
        }

        [Fact]
        public void ShouldConvertIntToEpoch()
        {
            const long @long = (int)762307200;
            var epoch = @long.ToEpoch();

            Assert.Equal(@long, epoch.Value);
        }
    }
}

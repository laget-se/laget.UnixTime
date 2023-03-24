using laget.UnixTime.Extensions;
using Xunit;

namespace laget.UnixTime.Tests.Extensions
{
    public class LongExtensionsTests
    {
        [Fact]
        public void ShouldConvertLongToEpoch()
        {
            const long @long = (long)762307200;
            var epoch = @long.ToEpoch();

            Assert.Equal(@long, epoch.Value);
        }
    }
}

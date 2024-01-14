﻿using laget.UnixTime.Extensions;
using System;
using Xunit;

namespace laget.UnixTime.Tests
{
    public class UnixTimeTests
    {
        [Fact]
        public void ShouldReturnCorrectLocalNow()
        {
            var unixTime = new UnixTime(Providers.TimeProvider.System);

            var expected = Epoch.Now.ToLocal();
            var actual = unixTime.Now();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldConvertEpochToSpecifiedTimeZone()
        {
            var timezone = TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time");
            var unixTime = new UnixTime(Providers.TimeProvider.Timezone(timezone));

            var expected = DateTime.Now.ToEpoch(timezone);
            var actual = unixTime.Now();

            Assert.Equal(expected, actual);
        }
    }
}

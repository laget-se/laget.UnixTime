using System;

namespace laget.UnixTime.Extensions
{
    public static class DateTimeExtensions
    {
        public static Epoch ToEpoch(this DateTime dateTime) =>
            new Epoch(dateTime);
    }
}

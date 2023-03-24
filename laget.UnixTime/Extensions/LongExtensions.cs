namespace laget.UnixTime.Extensions
{
    public static class LongExtensions
    {
        public static Epoch ToEpoch(this long @long) =>
            new Epoch(@long);
    }
}

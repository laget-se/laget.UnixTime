namespace laget.UnixTime.Extensions
{
    public static class IntExtensions
    {
        /// <summary>
        /// This method will convert a long value to an Epoch.
        /// </summary>
        /// <param name="long"></param>
        public static Epoch ToEpoch(this long @long) =>
            new Epoch(@long);

        /// <summary>
        /// This method will convert a int value to an Epoch.
        /// </summary>
        /// <param name="int"></param>
        public static Epoch ToEpoch(this int @int) =>
            new Epoch(@int);
    }
}

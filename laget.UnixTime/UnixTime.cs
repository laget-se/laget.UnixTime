using laget.UnixTime.Providers;

namespace laget.UnixTime
{
    public interface IUnixTime
    {
        Epoch Now();
        Epoch Zero();
    }

    public class UnixTime : IUnixTime
    {
        private readonly ITimeProvider _timeProvider;

        public UnixTime(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public Epoch Now()
        {
            return _timeProvider.Now();
        }

        public Epoch Zero()
        {
            return _timeProvider.Zero();
        }
    }
}

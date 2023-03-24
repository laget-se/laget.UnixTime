using laget.UnixTime.Extensions;
using System;
using System.Globalization;

namespace laget.UnixTime
{
    public struct Epoch : IComparable<Epoch>, IEquatable<Epoch>
    {
        internal long InternalTicks;
        internal static DateTime StartsAt => new DateTime(1970, 01, 01, 0, 0, 0, DateTimeKind.Utc);

        /// <summary>
        /// This method converts long to Epoch.
        /// </summary>
        /// <param name="value"></param>
        public Epoch(long value)
        {
            InternalTicks = value;
        }

        /// <summary>
        /// This method that converts a DateTime to Epoch, if the DateTime is supplied with
        /// milliseconds those will be reset to zero since the resolution of Epoch is
        /// seconds.
        /// </summary>
        /// <param name="datetime"></param>
        public Epoch(DateTime datetime)
        {
            InternalTicks = (long)new DateTime(
                    datetime.Year,
                    datetime.Month,
                    datetime.Day,
                    datetime.Hour,
                    datetime.Minute,
                    datetime.Second,
                    0,
                    DateTimeKind.Utc)
                .Subtract(StartsAt)
                .TotalSeconds;
        }

        /// <summary>
        /// This method converts int to Epoch (long).
        ///
        /// This should not be used and are to be removed when all epoch have been
        /// converted to long.
        /// </summary>
        /// <param name="value"></param>
        [Obsolete("This method will be removed when all of our epoch properties have been converted to Epoch (long)!")]
        public Epoch(int value)
        {
            InternalTicks = value;
        }

        /// <summary>
        /// Provides a human-readable DateTime object.
        /// </summary>
        public DateTime DateTime => StartsAt.AddSeconds(InternalTicks);
        /// <summary>
        /// The actual epoch value in seconds (long).
        /// </summary>
        public long Value => InternalTicks;
        /// <summary>
        /// Gets a <see cref="T:Epoch"></see> object that is set to the
        /// current date and time on this computer, expressed as the
        /// Coordinated Universal Time (UTC).
        /// </summary>
        public static Epoch Now => new Epoch(DateTime.UtcNow);
        /// <summary>
        /// Gets a <see cref="T:Epoch"></see> object that is set to the
        /// beginning date and time off Epoch, expressed as the
        /// Coordinated Universal Time (UTC).
        /// </summary>
        public static Epoch Zero => new Epoch((long)0);

        #region Operators
        public static implicit operator long(Epoch epoch)
        {
            return epoch.InternalTicks;
        }

        public static implicit operator int(Epoch epoch)
        {
            return (int)epoch.InternalTicks;
        }

        public static bool operator ==(Epoch lhs, Epoch rhs)
        {
            if (ReferenceEquals(lhs, null))
            {
                return ReferenceEquals(rhs, null);
            }
            return lhs.Equals(rhs);
        }

        public static bool operator !=(Epoch lhs, Epoch rhs)
        {
            return !(lhs == rhs);
        }

        public static bool operator <(Epoch lhs, Epoch rhs)
        {
            return lhs.InternalTicks < rhs.InternalTicks;
        }

        public static bool operator >(Epoch lhs, Epoch rhs)
        {
            return lhs.InternalTicks > rhs.InternalTicks;
        }

        public static bool operator <=(Epoch lhs, Epoch rhs)
        {
            return lhs.InternalTicks <= rhs.InternalTicks;
        }

        public static bool operator >=(Epoch lhs, Epoch rhs)
        {
            return lhs.InternalTicks >= rhs.InternalTicks;
        }

        public static bool operator ==(Epoch lhs, long rhs)
        {
            if (ReferenceEquals(lhs, null))
            {
                return ReferenceEquals(rhs, null);
            }
            return lhs.Equals(new Epoch(rhs));
        }

        public static bool operator ==(Epoch lhs, int rhs)
        {
            if (ReferenceEquals(lhs, null))
            {
                return ReferenceEquals(rhs, null);
            }
            return lhs.Equals(new Epoch(rhs));
        }

        public static TimeSpan operator -(Epoch lhs, Epoch rhs)
        {
            return lhs.ToDateTime() - rhs.ToDateTime();
        }

        public static bool operator !=(Epoch lhs, long rhs)
        {
            return !(lhs == rhs);
        }

        public static bool operator !=(Epoch lhs, int rhs)
        {
            return !(lhs == rhs);
        }

        public static bool operator <(Epoch lhs, long rhs)
        {
            return lhs.InternalTicks < rhs;
        }

        public static bool operator <(Epoch lhs, int rhs)
        {
            return lhs.InternalTicks < rhs;
        }

        public static bool operator >(Epoch lhs, long rhs)
        {
            return lhs.InternalTicks > rhs;
        }

        public static bool operator >(Epoch lhs, int rhs)
        {
            return lhs.InternalTicks > rhs;
        }

        public static bool operator <=(Epoch lhs, long rhs)
        {
            return lhs.InternalTicks <= rhs;
        }
        public static bool operator <=(Epoch lhs, int rhs)
        {
            return lhs.InternalTicks <= rhs;
        }

        public static bool operator >=(Epoch lhs, long rhs)
        {
            return lhs.InternalTicks >= rhs;
        }

        public static bool operator >=(Epoch lhs, int rhs)
        {
            return lhs.InternalTicks >= rhs;
        }

        public static Epoch operator +(Epoch lhs, long rhs)
        {
            return new Epoch(lhs.InternalTicks + rhs);
        }

        public static Epoch operator +(Epoch lhs, int rhs)
        {
            return new Epoch(lhs.InternalTicks + rhs);
        }

        public static Epoch operator -(Epoch lhs, long rhs)
        {
            return new Epoch(lhs.InternalTicks - rhs);
        }

        public static Epoch operator -(Epoch lhs, int rhs)
        {
            return new Epoch(lhs.InternalTicks - rhs);
        }
        #endregion

        public int CompareTo(Epoch other)
        {
            var lhs = this.InternalTicks;
            var rhs = other.InternalTicks;

            if (lhs > rhs)
            {
                return 1;
            }

            return lhs < rhs ? -1 : 0;
        }

        public override bool Equals(object obj)
        {
            return obj is Epoch other && Equals(other);
        }

        public bool Equals(Epoch other)
        {
            var lhs = this.InternalTicks;
            var rhs = other.InternalTicks;

            return lhs == rhs;
        }

        /// <summary>
        /// Converts the epoch to a current local timespan.
        /// </summary>
        /// <returns></returns>
        public Epoch ToLocal()
        {
            return new Epoch(DateTime.ToLocalTime());
        }

        public override int GetHashCode()
        {
            return InternalTicks.GetHashCode();
        }

        /// <summary>Converts the value of the current <see cref="T:Epoch" /> object to its equivalent string representation using the formatting conventions of the current culture.</summary>
        /// <exception cref="T:System.ArgumentOutOfRangeException">The date and time is outside the range of dates supported by the calendar used by the current culture.</exception>
        /// <returns>A string representation of the value of the current <see cref="T:Epoch" /> object.</returns>
        public override string ToString()
        {
            return DateTime.ToString(CultureInfo.CurrentCulture);
        }

        /// <summary>Converts the value of the current <see cref="T:Epoch" /> object to its equivalent string representation using the specified format and the formatting conventions of the current culture.</summary>
        /// <param name="format">A standard or custom date and time format string.</param>
        /// <returns>A string representation of value of the current <see cref="T:Epoch" /> object as specified by <paramref name="format" />.</returns>
        /// <exception cref="T:System.FormatException">The length of <paramref name="format" /> is 1, and it is not one of the format specifier characters defined for <see cref="T:System.Globalization.DateTimeFormatInfo" />.
        /// -or-
        /// <paramref name="format" /> does not contain a valid custom format pattern.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">The date and time is outside the range of dates supported by the calendar used by the current culture.</exception>
        public string ToString(string format)
        {
            return DateTime.ToString(format);
        }

        /// <summary>Converts the value of the current <see cref="T:Epoch" /> object to its equivalent string representation using the specified culture-specific format information.</summary>
        /// <param name="provider">An object that supplies culture-specific formatting information.</param>
        /// <returns>A string representation of value of the current <see cref="T:Epoch" /> object as specified by <paramref name="provider" />.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">The date and time is outside the range of dates supported by the calendar used by <paramref name="provider" />.</exception>
        public string ToString(IFormatProvider provider)
        {
            return DateTime.ToString(provider);
        }

        /// <summary>Converts the value of the current <see cref="T:Epoch" /> object to its equivalent string representation using the specified format and culture-specific format information.</summary>
        /// <param name="format">A standard or custom date and time format string.</param>
        /// <param name="provider">An object that supplies culture-specific formatting information.</param>
        /// <returns>A string representation of value of the current <see cref="T:Epoch" /> object as specified by <paramref name="format" /> and <paramref name="provider" />.</returns>
        /// <exception cref="T:System.FormatException">The length of <paramref name="format" /> is 1, and it is not one of the format specifier characters defined for <see cref="T:System.Globalization.DateTimeFormatInfo" />.
        /// -or-
        /// <paramref name="format" /> does not contain a valid custom format pattern.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">The date and time is outside the range of dates supported by the calendar used by <paramref name="provider" />.</exception>
        public string ToString(string format, IFormatProvider provider)
        {
            return DateTime.ToString(format, provider);
        }
    }
}

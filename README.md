# laget.UnixTime
Implements a simple set of helpers to handle Epoch/Unix timestamps in .NET

## Usages
There are a few ways to create a Epoch

### `Epoch.Now`
> Will return the timestamp as if it was UTC.

This method will return the current timestamp in seconds from the UnixTime-epoch.

### `Epoch.Zero`
> This method will always return the timestamp as if it was UTC.

This method will return the beginning of the UnixTime-epoch (1 January 1970 00:00:00 UTC).

### `new Epoch(int value)`
> This method will always return the timestamp as if it was UTC.
> The year 2038 problem (also known as Y2038, Y2K38, or the Epochalypse) is a time formatting bug in computer systems with representing times after 03:14:07 UTC on 19 January 2038.

This method will return the provided value (`int`) as an UnixTime-epoch, we do not recommend this way since it will overflow after 03:14:07 UTC on 19 January 2038.

### `new Epoch(long value)`
> This method will always return the timestamp as if it was UTC.

This method will return the provided value (`long`) as an UnixTime-epoch.

### `new Epoch(DateTime datetime)`
> Will return the timestamp as if the DateTime was in UTC.

This method will return the provided value (`DateTime`) as an UnixTime-epoch.

### TimeProvider
```c#
var tp = TimeProvider.System;
var epoch = tp.Now();
```

```c#
var tp = TimeProvider.Utc;
var epoch = tp.Now();
```

```c#
var timezone = TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time");
var tp = TimeProvider.Timezone(timezone);
var epoch = tp.Now();
```

### Extensions
We've provided a few ways to simplify the conversion of types that can be converted to a UnixTime-epoch value, such as `int`, `long`, and `DateTime`.

#### DateTime
##### `ToEpoch()`
> This method will always return the timestamp as if it was UTC.

This method will return the provided value (`DateTime`) as an UnixTime-epoch.

##### `ToEpoch(DateTimeKind kind)`
> This method will always return the timestamp as if it was UTC.

This method will return the provided value (`DateTime`) with the provided `DateTimeKind` (`Local`, `Unspecified`, and `Utc`) taken into account as an UnixTime-epoch.

##### `ToEpoch(TimeZoneInfo timeZoneInfo)`
This method will convert the provided value (`DateTime`) to an UnixTime-epoch adjusted for provided time zone.

#### Epoch
##### `BeginningOfMinute()`
This method will return the original Epoch but with the timespan adjusted to the beginning of the current minute.

##### `EndOfMinute()`
This method will return the original Epoch but with the timespan adjusted to the end of the current minute.

##### `BeginningOfHour()`
This method will return the original Epoch but with the timespan adjusted to the beginning of the current hour.

##### `EndOfHour()`
This method will return the original Epoch but with the timespan adjusted to the end of the current hour.

##### `BeginningOfDay()`
This method will return the original Epoch but with the timespan adjusted to the beginning of the current day.

##### `EndOfDay()`
This method will return the original Epoch but with the timespan adjusted to the end of the current day.

##### `BeginningOfMonth()`
This method will return the original Epoch but with the timespan adjusted to the beginning of the current month.

##### `EndOfMonth()`
This method will return the original Epoch but with the timespan adjusted to the end of the current month.

##### `BeginningOfYear()`
This method will return the original Epoch but with the timespan adjusted to the beginning of the current year.

##### `EndOfYear()`
This method will return the original Epoch but with the timespan adjusted to the end of the current year.

##### `ToDateTime()`
This method will convert the provided Epoch to a `DateTime`.

##### `InTimezone(TimeZoneInfo timeZoneInfo)`
This method will return the current Epoch converted to a time zone specific adjusted Epoch.

#### Integers
##### `(int)value.ToEpoch()`
> The year 2038 problem (also known as Y2038, Y2K38, or the Epochalypse) is a time formatting bug in computer systems with representing times after 03:14:07 UTC on 19 January 2038.

This method will return the provided value (`int`) as an UnixTime-epoch, we do not recommend this way since it will overflow after 03:14:07 UTC on 19 January 2038.

##### `(long)value.ToEpoch()`
This method will return the provided value (`long`) as an UnixTime-epoch.
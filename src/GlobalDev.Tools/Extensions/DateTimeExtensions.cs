using GlobalDev.Tools.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalDev.Tools.Extensions
{
    public static class DateTimeExtensions
    {
        public static DateTime EndDay(this DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 23, 59, 59, dateTime.Kind);
        }

        public static DateTime InitDay(this DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 00, 00, 00, dateTime.Kind);
        }

        public static DateTime ChangeTime(this DateTime dateTime, int hours, int minutes, int seconds = default, int milliseconds = default)
        {
            return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, hours, minutes, seconds, milliseconds, dateTime.Kind);
        }

        public static TimeSpan Multiply(this TimeSpan multiplicand, int multiplier)
        {
            return TimeSpan.FromTicks(multiplicand.Ticks * multiplier);
        }

        public static TimeSpan Multiply(this TimeSpan multiplicand, double multiplier)
        {
            return TimeSpan.FromTicks((long)(multiplicand.Ticks * multiplier));
        }

        public static int IntervalDays(this DateTime startDate, DateTime endDate)
        {
            var interval = endDate - startDate;
            return interval.Days;
        }

        public static double IntervalHours(this DateTime startDate, DateTime endDate)
        {
            var interval = endDate - startDate;
            return interval.TotalHours;
        }

        public static IntervalDate Interval(this DateTime startDate, DateTime endDate)
        {
            var interval = endDate - startDate;
            return new IntervalDate(interval);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalDev.Tools.Models
{
    public class IntervalDate
    {
        public int Days { get; set; }
        public double Hours { get; set; }
        public double Minutes { get; set; }
        public double Seconds { get; set; }
        public double Milliseconds { get; set; }

        public IntervalDate(TimeSpan interval)
        {
            Days = interval.Days;
            Hours = interval.Hours;
            Minutes = interval.Minutes;
            Seconds = interval.Seconds;
            Milliseconds = interval.Milliseconds;
        }
    }
}

﻿using System;
using Com.Microsoft.Tang.Annotations;

namespace Com.Microsoft.Tang.Examples
{
    public class Timer
    {
        [NamedParameter(typeof(System.String), "Number of seconds to sleep", "10", "sec")]
        class Seconds : Name<Int32> { }
        private readonly int seconds;

        [Inject]
        public Timer([Parameter(Value = typeof(Seconds))] int seconds)
        {
            if (seconds < 0)
            {
                throw new ArgumentException("Cannot sleep for negative time!");
            }
            this.seconds = seconds;
        }
    }
}

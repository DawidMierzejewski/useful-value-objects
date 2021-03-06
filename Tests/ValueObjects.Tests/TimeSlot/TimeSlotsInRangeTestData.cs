﻿using System;
using Xunit;

namespace ValueObjects.Tests
{
    public class TimeSlotsInRangeTestData : TheoryData<TimeSlot>
    {
        public TimeSlotsInRangeTestData()
        {
            Add(new TimeSlot(
                new TimeSpan(10, 10, 0),
                new TimeSpan(10, 30, 0)));
            Add(new TimeSlot(
                new TimeSpan(10, 10, 0),
                new TimeSpan(10, 15, 0)));
            Add(new TimeSlot(
                new TimeSpan(10, 17, 0),
                new TimeSpan(10, 29, 0)));
            Add(new TimeSlot(
                new TimeSpan(10, 15, 0),
                new TimeSpan(10, 30, 0)));
            Add(new TimeSlot(
                new TimeSpan(10, 29, 0),
                new TimeSpan(10, 31, 0)));
        }
    }
}

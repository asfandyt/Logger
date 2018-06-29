using System;
using System.Collections.Generic;
using System.Text;

namespace JSONify.Models
{
    public class Activity
    {
        public Activity()
        {
            ActivityStartTime = DateTimeOffset.Now;
        }

        public DateTimeOffset? ActivityStartTime { get; set; }

        public DateTimeOffset? ActivityEndTime { get; set; }

        public double? TotalTimeElapsed { get; set; }

        public string Description { get; set; }

        public void UpdateTimeElapsed()
        {
            ActivityEndTime = DateTimeOffset.Now;

            TotalTimeElapsed = ActivityStartTime.HasValue
                ? ActivityEndTime.Value.Subtract(ActivityStartTime.Value).TotalMilliseconds : 0;
        }
    }
}

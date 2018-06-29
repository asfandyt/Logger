using System;
using System.Collections.Generic;
using System.Text;

namespace JSONify.Models
{
    public class Log
    {
        public static List<Activity> Activity { get; set; }

        public static DateTime? StarTime { get; set; }

        public static DateTime? AppEndTime { get; set; }

        public static Exception Exception { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace JSONify.Models
{
    public static class LogStatic
    {
        public static List<Activity> Activity { get; set; }

        public static DateTime? StarTime { get; set; }

        public static DateTime? AppEndTime { get; set; }

        public static Exception Exception { get; set; }
    }
}

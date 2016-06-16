using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitnessCenterReservation.Models
{
    public class GymClass
    {
        public string Name { get; set; }

        public DateTime StartTime { get; set; }

        public TimeSpan Duration { get; set; }

        public DateTime EndTime {
            get {
                return StartTime + Duration;
            }
        }

        public string Description { get; set; }
    }
}

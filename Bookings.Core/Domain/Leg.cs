using System;
namespace Bookings.Core.Domain
{
    public class Leg
    {
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime Departure { get; set; }
        public DateTime Arrival { get; set; }
        public bool IsDirect { get; set; }
    }
}

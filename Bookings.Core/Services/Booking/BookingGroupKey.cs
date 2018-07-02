using System;
namespace Bookings.Core.Services
{
    public class BookingGroupKey
    {
        public string VesselName { get; set; }
        public string CrewChangeAirport { get; set; }
        public DateTime CrewChangeDate { get; set; }

        public override string ToString()
        {
            return $"{VesselName} {CrewChangeAirport} {CrewChangeDate}";
        }
    }
}

using System;
namespace Bookings.Core.Domain
{
    public class Metadata
    {
        public string VesselName { get; set; }
        public string VesselFlag { get; set; }
        public string CrewChangeMember { get; set; }
        public string CrewChangeAirport { get; set; }
        public DateTime CrewChangeDate { get; set; }
    }
}

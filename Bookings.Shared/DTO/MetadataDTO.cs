using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Bookings.Shared.DTO
{
    public class MetadataDTO
    {
        public string VesselName { get; set; }
        public string VesselFlag { get; set; }
        public string CrewChangeMember { get; set; }
        public string CrewChangeAirport { get; set; }
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime CrewChangeDate { get; set; }
    }
}

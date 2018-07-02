using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Bookings.Shared.DTO
{
    public class LegDTO
    {
        public string Origin { get; set; }
        public string Destination { get; set; }
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Departure { get; set; }
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Arrival { get; set; }
        public bool IsDirect { get; set; }
    }
}

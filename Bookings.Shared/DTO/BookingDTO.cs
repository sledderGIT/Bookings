using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Bookings.Shared.DTO
{
    public class BookingDTO
    {
        public string Id { get; set; }
        public string Locator { get; set; }
        public string PaxName { get; set; }
        public TermDTO Terms { get; set; }
        public MetadataDTO Metadata { get; set; }
        public string State { get; set; }
        public PriceDTO Price { get; set; }
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? DepartureAt { get; set; }
        public List<LegDTO> Legs { get; set; }
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? CreatedAt { get; set; }
    }
}



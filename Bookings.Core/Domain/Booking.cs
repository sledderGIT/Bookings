using System;
using System.Collections.Generic;
using System.Linq;

namespace Bookings.Core.Domain
{
    public class Booking
    {
        public string Id { get; set; }
        public string Locator { get; set; }
        public string PaxName { get; set; }
        public Term Terms { get; set; }
        public Metadata Metadata { get; set; }
        public Price Price { get; set; }
        public DateTime? DepartureAt { get; set; }
        public List<Leg> Legs { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string State { get; set; }
    }
}



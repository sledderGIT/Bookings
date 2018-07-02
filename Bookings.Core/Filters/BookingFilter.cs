using System;
using System.Collections.Generic;
using System.Linq;
using Bookings.Core.Domain;
using Bookings.Core.Services;

namespace Bookings.Core.Filters
{
    public static class BookingFilter
    {
        public static IEnumerable<BookingGroup> GroupBookings(IEnumerable<Booking> bookings)
        {
            return bookings.GroupBy(s => new { s.Metadata.VesselName, s.Metadata.CrewChangeDate, s.Metadata.CrewChangeAirport })
                           .Select(s => new BookingGroup(new BookingGroupKey
                           {
                               VesselName = s.Key.VesselName,
                               CrewChangeAirport = s.Key.CrewChangeAirport,
                               CrewChangeDate = s.Key.CrewChangeDate
                           }, s));
        }
    }
}

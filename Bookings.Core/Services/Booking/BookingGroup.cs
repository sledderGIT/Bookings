using System;
using System.Collections.Generic;
using Bookings.Core.Domain;

namespace Bookings.Core.Services
{
    public class BookingGroup: List<Booking>
    {
        public BookingGroupKey Key { get; set; }
        public BookingGroup(BookingGroupKey key, IEnumerable<Booking> bookings): base(bookings)
        {
            Key = key;
        }
    }
}

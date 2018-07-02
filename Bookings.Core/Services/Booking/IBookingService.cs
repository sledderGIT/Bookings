using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bookings.Core.Domain;

namespace Bookings.Core.Services
{
    public interface IBookingService
    {
        Task<IEnumerable<Booking>> GetBookings();
    }
}

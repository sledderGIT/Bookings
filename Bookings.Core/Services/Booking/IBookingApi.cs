using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bookings.Shared.DTO;
using Refit;

namespace Bookings.Core.Services
{
    public interface IBookingApi
    {
        [Headers("Content-Type: application/json")]
        [Get("/bookings")]
        Task<IEnumerable<BookingDTO>> GetBookings();
    }
}
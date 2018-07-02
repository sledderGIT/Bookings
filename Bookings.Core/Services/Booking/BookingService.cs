using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Bookings.Core.Domain;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Refit;

namespace Bookings.Core.Services
{
    public class BookingService: IBookingService
    {
        IBookingApi _api;
        public BookingService()
        {
            _api = RestService.For<IBookingApi>(Constants.API.BaseUrl, Constants.API.BaseSettings);
        }

        public async Task<IEnumerable<Booking>> GetBookings()
        {
            var response = await _api.GetBookings();
            return Mapper.Map<IEnumerable<Booking>>(response);
        }
    }
}

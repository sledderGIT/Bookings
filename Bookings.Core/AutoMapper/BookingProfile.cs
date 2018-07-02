using System;
using AutoMapper;
using Bookings.Core.Domain;
using Bookings.Shared.DTO;

namespace Bookings.Core.AutoMapper
{
    public class BookingProfile: Profile
    {
        public BookingProfile()
        {
            CreateMap<TermDTO, Term>();
            CreateMap<MetadataDTO, Metadata>();
            CreateMap<PriceDTO, Price>();
            CreateMap<LegDTO, Leg>();
            CreateMap<BookingDTO, Booking>();
        }
    }
}

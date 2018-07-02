using System;
using AutoMapper;

namespace Bookings.Core.AutoMapper
{
    public class AutomapperInitializer
    {
        public static void Initialize()
        {
            Mapper.Initialize(cfg => {
                cfg.AddProfile<BookingProfile>();
            });
        }
    }
}

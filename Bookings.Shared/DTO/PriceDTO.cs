using System;
namespace Bookings.Shared.DTO
{
    public class PriceDTO
    {
        public decimal Total { get; set; }
        public decimal PerMile { get; set; }
        public string Ccy { get; set; }
    }
}

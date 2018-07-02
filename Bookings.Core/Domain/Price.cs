using System;
namespace Bookings.Core.Domain
{
    public class Price
    {
        public decimal Total { get; set; }
        public decimal PerMile { get; set; }
        public string Ccy { get; set; }
    }
}

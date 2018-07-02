using System;
namespace Bookings.Shared.DTO
{
    public class TermDTO
    {
        public string FareType { get; set; }
        public string Conditions { get; set; }
        public bool Splitting { get; set; }
    }
}
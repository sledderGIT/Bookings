using System;
namespace Bookings.Core.Domain
{
    public class Term
    {
        public string FareType { get; set; }
        public string Conditions { get; set; }
        public bool Splitting { get; set; }
    }
}
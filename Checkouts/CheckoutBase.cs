using System.Collections.Generic;
using CashRegister.Offers;
using CashRegister.Orders;

namespace CashRegister.Checkouts
{
    public abstract class CheckoutBase
    {
        public ICollection<OrderBase> Orders { get; set; }
        public ICollection<OfferBase> Offers { get; set; }
        public decimal Discount { get; set; }
        public decimal Fee { get; set; }
        public decimal Sum { get; set; }
    }
}
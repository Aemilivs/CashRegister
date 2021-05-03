using System.Collections.Generic;
using CashRegister.Bags;
using CashRegister.Checkouts;
using CashRegister.Customers;
using CashRegister.Offers;

namespace CashRegister.Registers
{
    public abstract class RegisterBase
    {
        public ICollection<OfferBase> Offers { get; set; }

        public BagBase BagType { get; set; }

        public abstract CheckoutBase Checkout(CustomerBase customer);
    }
}
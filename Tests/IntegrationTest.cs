using System;
using System.Collections.Generic;
using CashRegister.Bags;
using CashRegister.Carts;
using CashRegister.Customers;
using CashRegister.Items;
using CashRegister.Offers;
using CashRegister.Orders;
using CashRegister.Registers;
using NUnit.Framework;

namespace Tests
{
    public class IntegrationTest
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            var offers = 
                new List<OfferBase>
                {
                    new DefaultOfferA(),
                    new DefaultOfferB()
                };
            var bagType = new DefaultBag();
            var register = new DefaultRegister(offers, bagType);

            var cart = new DefaultCart();
            var customer = new DefaultCustomer(cart);

            var items = 
                new[]
                {
                    new DefaultItem("A", 50),
                    new DefaultItem("B", 30),
                    new DefaultItem("C", 20),
                    new DefaultItem("D", 15),
                };

            customer.AddItemToCart(new DefaultOrder(items[0], 3));
            customer.AddItemToCart(new DefaultOrder(items[1], 2));
            customer.AddItemToCart(new DefaultOrder(items[2], 1));
            customer.AddItemToCart(new DefaultOrder(items[3], 1));

            var checkout = register.Checkout(customer);

            Console.WriteLine(checkout.Fee);
            Console.WriteLine(checkout.Discount);
            Console.WriteLine(checkout.Sum);
        }
    }
}
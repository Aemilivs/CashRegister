namespace CashRegister.Bags
{
    public abstract class BagBase
    {
        public decimal Price { get; set; }
        public int Capacity { get; set; }
        public int Occupancy { get; set; }
    }
}
namespace Contracts
{
    public class Order
    {
        public Guid Id { get; set; }
        public required string CustomerName { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
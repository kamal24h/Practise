
namespace PractiseConsoleApp
{
    public class Order
    {
        private static int nextOrderId = 1;
        public int OrderId { get; }
        public decimal TotalAmount { get; set; }
        
        public Order(decimal totalAmount)
        {
            OrderId = nextOrderId++;
            TotalAmount = totalAmount;
        }
    }
}


namespace PractiseConsoleApp
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string? Name { get; set; }
        public string? ShippingAddress { get; set; }
        public string? Email { get; set; }
        public List<Order>? Orders { get; set; }
        
        public void PlaceOrder(Order order)
        {
            Orders?.Add(order);
            Console.WriteLine($"Order {order.OrderId} placed by {Name}");
        }
    }
}

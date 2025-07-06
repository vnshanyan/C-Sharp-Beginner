namespace Homework14
{
    public class OrderService : IOrderService
    {
        private readonly IRestaurantService _restaurant;
        private readonly IPaymentService _payment;
        private readonly Dictionary<Guid, Order> _orders = new();
        public OrderService(IRestaurantService restaurant, IPaymentService? payment = null)
        {
            _restaurant = restaurant;
            _payment = payment;
        }
        public bool ValidateItems(List<string> productIds)
        {
            return productIds.All(id => _restaurant.GetProductById(id) != null);
        }

        public decimal CalculateTotal(List<string> productIds)
        {
            decimal total = 0;
            for (int i = 0; i < productIds.Count; i++)
            {
                total += _restaurant.GetProductById(productIds[i]).Price;
            }
            return total;
        }

        public Guid PlaceOrder(List<string> productIds)
        {
            if (!ValidateItems(productIds))
            {
                throw new InvalidOperationException("One or more items are invalid or unavailable.");
            }

            List<Product> items = productIds.Select(id => _restaurant.GetProductById(id)!).ToList();

            Order order = new Order
            {
                Items = items,
                TotalPrice = items.Sum(i => i.Price),
                Status = StatusTypes.Placed
            };
            _orders[order.OrderId] = order;

            if (_payment != null)
            {
                bool paid = _payment.ProcessPayment(order.OrderId, order.TotalPrice);
                order.Status = paid ? StatusTypes.Paid : StatusTypes.Failed;
            }
            return order.OrderId;
        }

        public Order? GetOrder(Guid id) => _orders.TryGetValue(id, out var currentOrder) ? currentOrder : null;
    }
}

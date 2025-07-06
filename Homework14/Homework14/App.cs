namespace Homework14
{
    public class App 
    {
        private readonly IRestaurantService _restaurant;
        private readonly IOrderService _order;
        private readonly IDeliveryService _delivery;
        public App(IRestaurantService restaurant, IOrderService order, IDeliveryService delivery)
        {
            _restaurant = restaurant;
            _order = order;
            _delivery = delivery;
        }
        public void Run()
        {
            var menu = _restaurant.GetAvailableProducts();
            Console.WriteLine("Available Products:");
            foreach (var product in menu)
            {
                Console.WriteLine($"{product.Id}: {product.Name} - {product.Price:C}");
            }
            var selectedIds = new List<string> { "burger-001", "fries-002" };
            if (!_order.ValidateItems(selectedIds))
            {
                Console.WriteLine("Some items are not available.");
                return;
            }
            var total = _order.CalculateTotal(selectedIds);
            Console.WriteLine($"Total Price: {total:C}");
            var orderId = _order.PlaceOrder(selectedIds);
            _delivery.AssignCourier(orderId);
            Console.WriteLine($"Delivery Status: {_delivery.GetDeliveryStatus(orderId)}");
        }
    }
}

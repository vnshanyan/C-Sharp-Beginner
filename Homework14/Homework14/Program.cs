
namespace Homework14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRestaurantService restaurantService = new RestaurantService();
            IPaymentService paymentService = new PaymentService();
            IOrderService orderService = new OrderService(restaurantService, paymentService);
            IDeliveryService deliveryService = new DeliveryService();

            App app = new App(restaurantService, orderService, deliveryService);
            app.Run();
        }
    }
}

/*
C# Homework Assignment
Topic: Interface-Based Design in a Modular Food Delivery System
Goal: Learn how to define and use service interfaces with proper domain modeling and service communication.
Scenario: Food Delivery Application
You are part of a backend development team for a new food delivery platform like Uber Eats or Glovo. 
The system is being built using modular services that interact with each other via well-defined interfaces.
Your task is to design and implement three cooperating services, each using a contract interface, and demonstrate how they work together.
Services to Design
1. Restaurant Service
This service manages the menu and provides information about available food items.
Interface: IRestaurantService
public interface IRestaurantService
{
    List<Product> GetAvailableProducts();              // Returns the available menu items
    Product? GetProductById(string productId);         // Find product details by ID
}
2. Order Service
Handles order creation, item validation, and cost calculation.
Interface: IOrderService
public interface IOrderService
{
    Guid PlaceOrder(List<string> productIds);          // Places an order by product IDs
    decimal CalculateTotal(List<string> productIds);   // Returns total price for selected items
    bool ValidateItems(List<string> productIds);       // Checks if all products are valid and available
}
3. Delivery Service
Manages courier assignment and delivery tracking for placed orders.
Interface: IDeliveryService
public interface IDeliveryService
{
    bool AssignCourier(Guid orderId);                  // Simulates courier assignment
    string GetDeliveryStatus(Guid orderId);            // Returns current delivery status
}
Shared Model
Product.cs
public class Product
{
    public string Id { get; set; }              // e.g., "burger-001"
    public string Name { get; set; }            // e.g., "Burger"
    public decimal Price { get; set; }          // e.g., 5.99
    public bool IsAvailable { get; set; }       // Whether the item is currently available
}
Example Console Program
Program Flow:
1. Display the available products from the menu.
2. Choose a few items (hardcoded IDs) to order.
3. Validate that the selected items are available.
4. Calculate the total cost.
5. Place the order and receive an order ID.
6. Assign a courier to the order.
7. Display the delivery status.
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
            Console.WriteLine($"{product.Id}: {product.Name} - {product.Price:C}");
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
Requirements Checklist
Requirement        Description
Interfaces         All three services must be defined via interfaces.
Model Usage        Product class must be used in all relevant places.
Service Cooperation The three services must interact through their interfaces.
Console Program    A test app must demonstrate the complete ordering and delivery flow.
Code Quality       Use clear naming, clean code, and realistic logic.
Bonus Challenges
- Add an IPaymentService that simulates processing a payment before placing an order.
- Add a class Order with properties like items, total price, and status.
- Implement error handling for missing or invalid products.
 */
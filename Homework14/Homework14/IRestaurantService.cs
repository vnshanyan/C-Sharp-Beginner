namespace Homework14
{
    public interface IRestaurantService
    {
        List<Product> GetAvailableProducts();    // Returns the available menu items
        Product? GetProductById(string productId);  // Find product details by ID
    }
}

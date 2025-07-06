
namespace Homework14
{
    public class RestaurantService : IRestaurantService
    {
        public readonly List<Product> _menu = new List<Product>()
        {
            new Product { Id = "burger-001", Name = "Burger", Price = 5.99m, IsAvailable = true  },
            new Product { Id = "fries-002", Name = "Fries", Price = 2.49m, IsAvailable = true  },
            new Product { Id = "cola-003", Name = "Cola", Price = 1.50m, IsAvailable = false },
            new Product { Id = "pizza-004", Name = "Pizza", Price = 7.99m, IsAvailable = true  }
        };

        public List<Product> GetAvailableProducts()
        {
            return _menu.Where(product => product.IsAvailable).ToList();
        }

        public Product? GetProductById(string productId)
        {
            Product? product = default;
            Console.WriteLine($"Product default value: {product}");
            for (int i = 0; i < _menu.Count; i++)
            {
                if (_menu[i].Id == productId && _menu[i].IsAvailable)
                {
                    product = _menu[i];
                }
            }
            return product;
        }
    }
}

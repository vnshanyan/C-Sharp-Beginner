namespace Homework15
{
    public class ProductPriceComparison
    {
        public ProductPriceComparison()
        {
            //1.Product Price Comparison
            //------------------------------------------------
            //Topic: IComparable<Product>
            //Model a `Product` class with the following fields:
            //- string Name
            //- decimal Price
            //- double Rating
            //Tasks:
            //- Implement IComparable<Product> to sort products by Price (ascending).
            //- Bonus: Add custom comparer `SortByRating` to sort by Rating (descending).

            List<Product> products = new List<Product>
            {
                new Product{Name = "Apple", Price = 200, Rating = 5},
                new Product{Name = "Mango", Price = 30000, Rating = 4},
                new Product{Name = "Kiwi", Price = 12, Rating = 0},
                new Product{Name = "Watermelon", Price = 24000, Rating = 10},
            };

            products.Sort();
            foreach (Product item in products)
            {
                Console.WriteLine(item.Price);
            }

            products.Sort(new SortByRating());
            foreach (Product item in products)
            {
                Console.WriteLine(item.Rating);
            }
        }
    }
}
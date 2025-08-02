namespace Homework15
{
    public class SortByRating : IComparer<Product>
    {
        public int Compare(Product? x, Product? y)
        {
            if (x is null || y is null) return 0;
            return y.Rating.CompareTo(x.Rating);
        }
    }
}
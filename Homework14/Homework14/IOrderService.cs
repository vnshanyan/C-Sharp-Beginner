namespace Homework14
{
    public interface IOrderService
    {
        Guid PlaceOrder(List<string> productIds);   // Places an order by product IDs
        decimal CalculateTotal(List<string> productIds);    // Returns total price for selected items
        bool ValidateItems(List<string> productIds);       // Checks if all products are valid and available
    }
}

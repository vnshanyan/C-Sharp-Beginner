namespace Homework14
{
    public class PaymentService : IPaymentService
    {
        public bool ProcessPayment(Guid orderId, decimal amount)
        {
            Console.WriteLine($"Processing payment of {amount:C} for order {orderId} paid.");
            return true;
        }
    }
}

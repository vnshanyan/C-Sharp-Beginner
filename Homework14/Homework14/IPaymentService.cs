namespace Homework14
{
    public interface IPaymentService
    {
        bool ProcessPayment(Guid orderId, decimal amount);
    }
}

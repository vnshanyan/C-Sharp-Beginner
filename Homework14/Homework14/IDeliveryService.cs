namespace Homework14
{
    public interface IDeliveryService
    {
        bool AssignCourier(Guid orderId);                  // Simulates courier assignment
        string GetDeliveryStatus(Guid orderId);            // Returns current delivery status
    }
}

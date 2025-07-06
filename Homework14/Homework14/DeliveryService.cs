
namespace Homework14
{
    public class DeliveryService : IDeliveryService
    {
        private readonly Dictionary<Guid, string> _status = new();
        public bool AssignCourier(Guid orderId)
        {
            _status[orderId] = "Courier assigned";
            return true;
        }

        public string GetDeliveryStatus(Guid orderId)
        {
            return _status.TryGetValue(orderId, out var status) ? status : "Unknown Order";
        }
    }
}

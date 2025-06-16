using shopData.Models;

namespace shop.Services
{
    public interface IOrderService
    {
        Task<bool> PlaceOrderAsync(int customerId, string deliveryAddress, List<CartItem> cartItems);
    }
}
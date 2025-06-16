using Microsoft.EntityFrameworkCore;
using shopData;
using shopData.Models;

namespace shop.Services
{
    public class OrderService : IOrderService
    {
        private readonly shopDbContext _db;

        public OrderService(shopDbContext db)
        {
            _db = db;
        }

        public async Task<bool> PlaceOrderAsync(int customerId, string deliveryAddress, List<CartItem> cartItems)
        {
            if (cartItems == null || cartItems.Count == 0) return false;

            var order = new Order
            {
                CustomerId = customerId,
                DeliveryAddress = deliveryAddress,
                OrderDate = DateTime.Now,
                OrderItems = new List<OrderItem>()
            };

            foreach (var item in cartItems)
            {
                var product = await _db.Products.FirstOrDefaultAsync(p => p.ProductId == item.Product.ProductId);
                if (product == null || product.Quantity < item.Quantity)
                    continue;

                order.OrderItems.Add(new OrderItem
                {
                    ProductId = product.ProductId,
                    Quantity = item.Quantity
                });

                product.Quantity -= item.Quantity;
            }

            if (order.OrderItems.Count == 0)
                return false;

            _db.Orders.Add(order);
            await _db.SaveChangesAsync();

            return true;
        }
    }
}

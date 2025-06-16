using System.Collections.Generic;
using System.Linq;
using shopData.Models;

public class CartService
{
    private readonly List<CartItem> _items = new();

    public List<CartItem> GetItems()
    {
        // Возвращаем копию списка, чтобы избежать внешних изменений
        return _items.ToList();
    }

    public void AddItem(Product product, int quantity)
    {
        var existingItem = _items.FirstOrDefault(i => i.Product.ProductId == product.ProductId);
        if (existingItem != null)
        {
            existingItem.Quantity += quantity;
        }
        else
        {
            _items.Add(new CartItem { Product = product, Quantity = quantity });
        }
    }

    public void RemoveItem(int productId)
    {
        var item = _items.FirstOrDefault(i => i.Product.ProductId == productId);
        if (item != null)
            _items.Remove(item);
    }

    public void UpdateQuantity(int productId, int quantity)
    {
        var item = _items.FirstOrDefault(i => i.Product.ProductId == productId);
        if (item != null)
        {
            if (quantity <= 0)
                _items.Remove(item);
            else
                item.Quantity = quantity;
        }
    }

    public void Clear()
    {
        _items.Clear();
    }
}

public class CartItem
{
    public Product Product { get; set; } = null!;
    public int Quantity { get; set; }
}

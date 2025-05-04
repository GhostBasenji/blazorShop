using Data.Models;

public partial class CartItem
{
    public int CartItemId { get; set; }
    public int CustomerId { get; set; }  // Идентификатор клиента
    public int ProductId { get; set; }   // Идентификатор товара
    public int Quantity { get; set; }    // Количество товара в корзине

    public virtual Product Product { get; set; } = null!;
    public virtual Customer Customer { get; set; } = null!;
}


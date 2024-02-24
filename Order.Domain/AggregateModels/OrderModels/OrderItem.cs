using Order.Domain.SeedWork;

namespace Order.Domain.AggregateModels.OrderModels
{
  public class OrderItem: BaseEntity
  {
    public int Quantity { get; }
    
    public decimal Price { get; }
    
    public int ProductId { get; }

    public OrderItem(int quantity, decimal price, int productId)
    {
      Quantity = quantity;
      Price = price;
      ProductId = productId;
    }
  }
}
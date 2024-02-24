using System;
using System.Collections.Generic;
using Order.Domain.Event;
using Order.Domain.SeedWork;

namespace Order.Domain.AggregateModels.OrderModels
{
  public class Order : BaseEntity, IAggregateRoot
  {
    public DateTime OrderDate { get;}
    
    public string Description { get; }
    
    public string UserName { get; }
    
    public string OrderStatus { get; }

    public Address Address { get; }
    
    public ICollection<OrderItem> OrderItems { get; set; }

    public Order(DateTime orderDate, string description, string userName, string orderStatus, Address address, ICollection<OrderItem> orderItems)
    {
      if (orderDate < DateTime.Now)
        throw new Exception("Order Date must be greater than now!");

      if (address.City == "")
        throw new Exception("City cannot be empty!");
      
      OrderDate = orderDate;
      Description = description;
      UserName = userName;
      OrderStatus = orderStatus;
      Address = address;
      OrderItems = orderItems;
      
      AddDomainEvents(new OrderStartedDomainEvent(userName, this));
    }

    public void AddOrderItem(int quantity, decimal price, int productId)
    {
      OrderItem item = new(quantity, price, productId);

      OrderItems.Add(item);
    }
  }
}
using MediatR;

namespace Order.Domain.Event
{
  public class OrderStartedDomainEvent : INotification
  {
    public string UserName { get; }
    public AggregateModels.OrderModels.Order Order { get; }

    public OrderStartedDomainEvent(string userName, AggregateModels.OrderModels.Order order)
    {
      UserName = userName;
      Order = order;
    }
  }
}
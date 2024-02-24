using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Order.Application.Repository;
using Order.Domain.AggregateModels.BuyerModels;
using Order.Domain.Event;

namespace Order.Application.DomainEventHandlers
{
  public class OrderStartedDomainEventHandler : INotificationHandler<OrderStartedDomainEvent>
  {
    private readonly IBuyerRepository buyerRepository;

    public OrderStartedDomainEventHandler(IBuyerRepository buyerRepository)
    {
      this.buyerRepository = buyerRepository ?? throw new ArgumentNullException();
    }
    
    public Task Handle(OrderStartedDomainEvent notification, CancellationToken cancellationToken)
    {
      if (notification.Order.UserName == "")
      {
        Buyer buyer = new Buyer(notification.Order.UserName);
        
        //..
      }

      return Task.CompletedTask;
    }
  }
}
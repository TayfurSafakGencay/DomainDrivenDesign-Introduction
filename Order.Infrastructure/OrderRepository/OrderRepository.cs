using System.Threading.Tasks;
using Order.Application.Repository;

namespace Order.Infrastructure.OrderRepository
{
  public class OrderRepository : IOrderRepository
  {
    public Task<int> SaveChangesAsync()
    {
      return Task.FromResult(1);
    }
  }
}
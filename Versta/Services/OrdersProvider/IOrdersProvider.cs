using System.Collections.Generic;
using System.Threading.Tasks;
using Versta.Models;

namespace Versta.Services.OrdersProvider
{
    public interface IOrdersProvider
    {
        public Task AddAsync(Order order);
        public Task<IEnumerable<Order>> GetOrdersAsync();
        public Task<IEnumerable<Order>> GetOrdersAsync(int skip, int take);
    }
}

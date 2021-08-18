using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Versta.Data;
using Versta.Models;

namespace Versta.Services.OrdersProvider
{
    public class MockOrdersProvider : IOrdersProvider
    {
        private static object _lock = new();
        private static readonly List<Order> orders = SampleData.Data.ToList();

        public async Task<bool> AddAsync(Order order)
        {
            return await Task.Run(() => {
                lock(_lock)
                {
                    order.Id = Guid.NewGuid();
                    orders.Add(order);
                }
                return true;
            });
        }

        public async Task<IEnumerable<Order>> GetOrdersAsync() => await Task.Run(() => orders);
        public async Task<IEnumerable<Order>> GetOrdersAsync(int skip, int take) => await Task.Run(() => orders.Skip(skip).Take(take));
    }
}

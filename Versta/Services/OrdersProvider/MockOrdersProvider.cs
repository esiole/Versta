using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Versta.Models;

namespace Versta.Services.OrdersProvider
{
    public class MockOrdersProvider : IOrdersProvider
    {
        private static object _lock = new();
        private static readonly List<Order> orders = new()
        {
            new Order()
            {
                Id = Guid.NewGuid(),
                SenderCity = "Санкт-Петербург",
                SenderAddress = "Невский проспект 5к2, кв. 212",
                RecipientCity = "Москва",
                RecipientAddress = "Тверская улица 6, кв. 15",
                WeightInKg = 4.123,
                DateOfReceiving = new DateTime(2021, 10, 20)
            },
            new Order()
            {
                Id = Guid.NewGuid(),
                SenderCity = "Москва",
                SenderAddress = "Тверская улица 6, кв. 15",
                RecipientCity = "Санкт-Петербург",
                RecipientAddress = "Невский проспект 5к2, кв. 212",
                WeightInKg = 15.123,
                DateOfReceiving = new DateTime(2022, 1, 11)
            }
        };

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

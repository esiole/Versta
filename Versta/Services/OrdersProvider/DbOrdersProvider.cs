using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Versta.Data;
using Versta.Models;

namespace Versta.Services.OrdersProvider
{
    public class DbOrdersProvider : IOrdersProvider
    {
        private readonly VerstaDbContext db;

        public DbOrdersProvider(VerstaDbContext db)
        {
            this.db = db;
        }

        public async Task<bool> AddAsync(Order order)
        {
            db.Orders.Add(order);
            int countRecords = await db.SaveChangesAsync();
            return countRecords == 1;
        }

        public async Task<IEnumerable<Order>> GetOrdersAsync()
        {
            return await db.Orders.OrderBy(o => o.DateOfReceiving).ToListAsync();
        }

        public async Task<IEnumerable<Order>> GetOrdersAsync(int skip, int take)
        {
            return await db.Orders.OrderBy(o => o.DateOfReceiving).Skip(skip).Take(take).ToListAsync();
        }
    }
}

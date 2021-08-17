using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Versta.Models;
using Versta.Services.OrdersProvider;

namespace Versta.Controllers
{   
    public class Home : Controller
    {
        private readonly IOrdersProvider ordersProvider;

        public Home(IOrdersProvider ordersProvider)
        {
            this.ordersProvider = ordersProvider;
        }

        [Route("/")]
        public async Task<IActionResult> Index()
        {
            IEnumerable<Order> orders = await ordersProvider.GetOrdersAsync();
            return View(orders);
        }
    }
}

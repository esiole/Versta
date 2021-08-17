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
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            IEnumerable<Order> orders = await ordersProvider.GetOrdersAsync();
            return View(orders);
        }

        [Route("/add")]
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [Route("/add")]
        [HttpPost]
        public async Task<IActionResult> Add(Order order)
        {
            bool isAdded = await ordersProvider.AddAsync(order);
            if (isAdded)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return Add();
            }
        }
    }
}

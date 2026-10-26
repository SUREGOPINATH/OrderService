using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OrderService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetOrders()
        {
            var orders = new List<object>
            {
                new { Id = 101, ProductName = "Azure Devops Handbook", Quantity = 1, Status = "Completed" },
                new { Id = 102, ProductName = "PS5 Controller", Quantity = 1, Status = "In Progress" },
                new { Id = 103, ProductName = "Asus Laptop", Quantity = 5, Status = "Pending" }
            };
            return Ok(new { timestamp = DateTime.UtcNow, TotalOrders = orders.Count, Data = orders });
        }
    }
}

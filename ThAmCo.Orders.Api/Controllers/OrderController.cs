using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ThAmCo.Orders.Api.Data;

namespace ThAmCo.Orders.Api.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase {

        private readonly ILogger<OrderController> _logger;
        private readonly OrderContext _orderContext;

        public OrderController(ILogger<OrderController> logger, OrderContext orderContext) {
            _logger = logger;
            _orderContext = orderContext;
        }

        [HttpGet(Name = "GetOrders")]
        public async Task<IEnumerable<Order>> Get() {
            return await _orderContext.Orders.ToListAsync();
        }
    }
}

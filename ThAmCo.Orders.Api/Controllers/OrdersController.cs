using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ThAmCo.Orders.Api.Data;

namespace ThAmCo.Orders.Api.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase {

        private readonly ILogger<OrdersController> _logger;
        private readonly OrderContext _orderContext;

        public OrdersController(ILogger<OrdersController> logger, OrderContext orderContext) {
            _logger = logger;
            _orderContext = orderContext;
        }

        [HttpGet(Name = "GetOrders")]
        public async Task<ActionResult<IEnumerable<Order>>> Get() {
            return await _orderContext.Orders.ToListAsync();
        }

        [HttpGet("{id}", Name = "GetOrder")]
        public async Task<ActionResult<Order>> Get(int id) {
            var order = await _orderContext.FindAsync<Order>(id);

            if (order == null) return new NotFoundResult();

            return order;
        }



        [HttpPost(Name = "AddOrder")]
        public async Task<ActionResult> Post(PostOrderDto orderDto) {
            var order = new Order {
                CustomerId = orderDto.CustomerId,
                SubmittedDate = orderDto.SubmittedDate,
                Status = OrderStatus.Pending,
                OrderDetails = new List<OrderDetail>()
            };
            foreach (var detail in orderDto.OrderDetails) {
                order.OrderDetails.Add(new OrderDetail {
                    OrderId = detail.OrderId,
                    ProductId = detail.ProductId,
                    Quantity = detail.Quantity,
                    UnitPrice = detail.UnitPrice
                });
            }
            var orderId = await _orderContext.AddAsync(order);
            await _orderContext.SaveChangesAsync();
            return new CreatedAtRouteResult("GetOrder", new { id = orderId }, order);
        }

    }
}

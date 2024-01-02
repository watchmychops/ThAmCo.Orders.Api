using Microsoft.AspNetCore.Authorization;
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

        /// <summary>
        ///   Gets all orders with an optional parameter of the status
        /// </summary>
        /// <param name="orderStatus"></param>
        /// <returns></returns>
        [HttpGet(Name = "GetOrders")]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Order>>> Get([FromQuery] OrderStatus? orderStatus = null) {
            var orderQuery = _orderContext.Orders
                .Include(x => x.OrderDetails)
                .AsQueryable();

            if (orderStatus.HasValue) {
                orderQuery = orderQuery.Where(x => x.Status == orderStatus.Value);
            }
            return await orderQuery.ToListAsync();
        }

        [HttpGet("{id}", Name = "GetOrder")]
        [Authorize]
        public async Task<ActionResult<Order>> Get(int id) {
            // Include order details
            var order = await _orderContext.Orders
                .Include(x => x.OrderDetails)
                .ThenInclude(x => x.Product)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (order == null) return new NotFoundResult();

            return order;
        }

        [HttpPatch("{id}/status", Name = "UpdateOrderStatus")]
        [Authorize]
        public async Task<ActionResult> UpdateOrderStatus(int id, [FromBody] UpdateOrderStatusDto updateOrderStatusDto) {
            var order = await _orderContext.FindAsync<Order>(id);
            if (order == null) {
                // Return 404 not found
                return NotFound();
            }

            order.Status = updateOrderStatusDto.OrderStatus;
            order.UpdatedDate = DateTime.Now;
            await _orderContext.SaveChangesAsync();

            // Return 204 No Content
            return NoContent();
        }

        [HttpPatch("{id}/customerId", Name = "UpdateCustomerId")]
        [Authorize]
        public async Task<ActionResult> UpdateCustomerId(int id, [FromBody] int customerId) {
            var order = await _orderContext.FindAsync<Order>(id);
            if (order == null) {
                // Return 404 not found
                return NotFound();
            }

            order.CustomerId = customerId;
            await _orderContext.SaveChangesAsync();

            // Return 204 No Content
            return NoContent();
        }

        [HttpPost(Name = "AddOrder")]
        [Authorize]
        public async Task<ActionResult> Post(PostOrderDto orderDto) {
            var order = new Order {
                CustomerId = orderDto.CustomerId,
                SubmittedDate = orderDto.SubmittedDate,
                Status = OrderStatus.Pending,
                Notes = orderDto.Notes,
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

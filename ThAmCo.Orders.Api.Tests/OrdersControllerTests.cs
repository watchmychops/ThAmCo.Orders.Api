using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;
using ThAmCo.Orders.Api.Controllers;
using ThAmCo.Orders.Api.Data;

namespace ThAmCo.Orders.Api.Tests {
    public class OrdersControllerTests {

        private OrderContext CreateContext() {
            // Create a new context with an in-memory database
            // Unique name using GUID
            var options = new DbContextOptionsBuilder<OrderContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            OrderContext context = new(options);

            // Add sample data to the context
            List<Order> orders = new() {
                new () {
                    Id = 1,
                    CustomerId = 1,
                    Notes = "Test notes for first test order",
                    SubmittedDate = DateTime.Now,
                    Status = OrderStatus.Pending,
                    OrderDetails = new List<OrderDetail> {
                        new OrderDetail { OrderId = 1, ProductId = 1, Quantity = 10, UnitPrice = 100 }
                    }
                },
                new Order {
                    Id = 2,
                    CustomerId = 2,
                    Notes = "Test notes for second test order",
                    SubmittedDate = DateTime.Now.AddDays(-1),
                    Status = OrderStatus.Confirmed,
                    OrderDetails = new List<OrderDetail> {
                        new OrderDetail { OrderId = 2, ProductId = 1, Quantity = 5, UnitPrice = 200 }
                    }
                },
                new Order {
                    Id = 3,
                    CustomerId = 2,
                    Notes = "Test notes for third test order",
                    SubmittedDate = DateTime.Now.AddDays(-1),
                    Status = OrderStatus.Confirmed,
                    OrderDetails = new List<OrderDetail> {
                        new OrderDetail { OrderId = 2, ProductId = 1, Quantity = 5, UnitPrice = 200 }
                    }
                }
            };
            // Add the orders to the context
            context.Orders.AddRange(orders);
            context.SaveChanges();

            return context;
        }

        [Fact]
        public async Task GetOrders_ReturnsAllOrders() {
            using (var context = CreateContext()) {
                var mockLogger = new Mock<ILogger<OrdersController>>();
                var controller = new OrdersController(mockLogger.Object, context);

                var result = await controller.Get();

                var actionResult = Assert.IsType<ActionResult<IEnumerable<Order>>>(result);
                var orders = Assert.IsAssignableFrom<IEnumerable<Order>>(actionResult.Value);
                Assert.Equal(context.Orders.Count(), orders.Count());
            }
        }

        [Fact]
        public async Task GetOrders_WithConfirmedStatus_ReturnsConfirmedOrders() {

            var targetStatus = OrderStatus.Confirmed;

            using (var context = CreateContext()) {
                var mockLogger = new Mock<ILogger<OrdersController>>();
                var controller = new OrdersController(mockLogger.Object, context);

                var result = await controller.Get(targetStatus);

                var actionResult = Assert.IsType<ActionResult<IEnumerable<Order>>>(result);
                var orders = Assert.IsAssignableFrom<IEnumerable<Order>>(actionResult.Value);
                Assert.All(orders, order => Assert.Equal(targetStatus, order.Status));
            }
        }

        [Fact]
        public async Task GetOrder_WithValidId_ReturnsOrder() {
            var testId = 1;

            using (var context = CreateContext()) {
                var mockLogger = new Mock<ILogger<OrdersController>>();
                var controller = new OrdersController(mockLogger.Object, context);

                var result = await controller.Get(testId);

                var actionResult = Assert.IsType<ActionResult<Order>>(result);
                var order = Assert.IsType<Order>(actionResult.Value);
                Assert.Equal(testId, order.Id);
            }

        }

        [Fact]
        public async Task GetOrder_WithInvalidId_ReturnsNotFound() {
            var testId = -1;

            using (var context = CreateContext()) {
                var mockLogger = new Mock<ILogger<OrdersController>>();
                var controller = new OrdersController(mockLogger.Object, context);

                var result = await controller.Get(testId);

                Assert.IsType<NotFoundResult>(result.Result);
            }
        }

        [Fact]
        public async Task PostOrder_AddsNewOrder() {

            var newOrderDto = new PostOrderDto {
                CustomerId = 1,
                Notes = "Test notes for adding a new order",
                SubmittedDate = DateTime.Now,
                OrderDetails = new() {
                    new() { OrderId = 3, ProductId = 10, Quantity = 100, UnitPrice = 10.12m }
                }
            };

            using (var context = CreateContext()) {
                var mockLogger = new Mock<ILogger<OrdersController>>();
                var controller = new OrdersController(mockLogger.Object, context);

                var result = await controller.Post(newOrderDto);

                var createdAtRouteResult = Assert.IsType<CreatedAtRouteResult>(result);
                var order = Assert.IsType<Order>(createdAtRouteResult.Value);
                Assert.NotNull(context.Orders.FirstOrDefault(o => o.Id == order.Id));
            }
        }

        [Fact]
        public async Task PatchOrder_WithConfirmedStatus_UpdatesStatus() {

            var orderId = 1;
            var confirmedUpdateStatusDto = new UpdateOrderStatusDto { OrderStatus = OrderStatus.Confirmed };

            using (var context = CreateContext()) {
                var mockLogger = new Mock<ILogger<OrdersController>>();
                var controller = new OrdersController(mockLogger.Object, context);

                var result = await controller.UpdateOrderStatus(orderId, confirmedUpdateStatusDto);

                Assert.IsType<NoContentResult>(result);
                var updatedOrder = context.Orders.Find(orderId);
                Assert.Equal(OrderStatus.Confirmed, updatedOrder?.Status);

            }


        }
    }
}
using Microsoft.EntityFrameworkCore;

namespace ThAmCo.Orders.Api.Data {
    public class OrderContext : DbContext {
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<OrderDetail> OrderDetails { get; set; } = null!;

        public OrderContext(DbContextOptions<OrderContext> options) : base(options) {

        }
        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);

            builder.Entity<Order>(x => {
                x.Property(c => c.CustomerId).IsRequired();
                x.Property(c => c.SubmittedDate).IsRequired();
            });

            builder.Entity<Order>()
                .HasMany(o => o.OrderDetails)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Standing Lamp", Description = "Lamp that is very super cool" },
                new Product { Id = 2, Name = "Bookcase", Description = "A case for your books" },
                new Product { Id = 3, Name = "Ergonomic Chair", Description = "Comfortable and adjustable chair perfect for long working hours" },
                new Product { Id = 4, Name = "Wireless Keyboard", Description = "Sleek and responsive keyboard with long battery life" },
                new Product { Id = 5, Name = "Bluetooth Headphones", Description = "High-quality audio with noise cancellation feature" },
                new Product { Id = 6, Name = "Smart Watch", Description = "Stylish watch with fitness tracking and notifications" },
                new Product { Id = 7, Name = "Water Bottle", Description = "Insulated bottle to keep your drinks hot or cold for hours" },
                new Product { Id = 8, Name = "Backpack", Description = "Durable and spacious backpack, ideal for travel or daily use" },
                new Product { Id = 9, Name = "Table Lamp", Description = "Elegant lamp with adjustable brightness for reading or work" },
                new Product { Id = 10, Name = "Desk Organiser", Description = "Keep your workspace tidy with this multi-compartment organiser" }
            );

            builder.Entity<Order>().HasData(
                new Order { Id = 1, CustomerId = 1, Notes = "Please deliver to garage", Status = OrderStatus.Pending, SubmittedDate = new DateTime(2023, 7, 22, 10, 30, 10), UpdatedDate = new DateTime(2023, 7, 22, 10, 30, 10) },
                new Order { Id = 2, CustomerId = 2, Notes = "Leave at front desk", Status = OrderStatus.Confirmed, SubmittedDate = new DateTime(2023, 7, 23, 11, 15, 30), UpdatedDate = new DateTime(2023, 7, 23, 11, 15, 30) },
                new Order { Id = 3, CustomerId = 3, Notes = "Ring bell on arrival", Status = OrderStatus.Dispatched, SubmittedDate = new DateTime(2023, 7, 24, 12, 45, 00), UpdatedDate = new DateTime(2023, 7, 24, 12, 45, 00) },
                new Order { Id = 4, CustomerId = 4, Notes = "Contact on mobile before delivery", Status = OrderStatus.Pending, SubmittedDate = new DateTime(2023, 7, 25, 09, 30, 00), UpdatedDate = new DateTime(2023, 7, 25, 09, 30, 00) },
                new Order { Id = 5, CustomerId = 5, Notes = "Deliver after 5 PM", Status = OrderStatus.Confirmed, SubmittedDate = new DateTime(2023, 7, 26, 14, 20, 10), UpdatedDate = new DateTime(2023, 7, 26, 14, 20, 10) },
                new Order { Id = 6, CustomerId = 6, Notes = "Gate code is 1234", Status = OrderStatus.Dispatched, SubmittedDate = new DateTime(2023, 7, 27, 10, 50, 00), UpdatedDate = new DateTime(2023, 7, 27, 10, 50, 00) },
                new Order { Id = 7, CustomerId = 7, Notes = "No signature required", Status = OrderStatus.Pending, SubmittedDate = new DateTime(2023, 7, 28, 16, 05, 20), UpdatedDate = new DateTime(2023, 7, 28, 16, 05, 20) },
                new Order { Id = 8, CustomerId = 8, Notes = "Call on arrival, allergic to dogs", Status = OrderStatus.Confirmed, SubmittedDate = new DateTime(2023, 7, 29, 13, 30, 45), UpdatedDate = new DateTime(2023, 7, 29, 13, 30, 45) },
                new Order { Id = 9, CustomerId = 9, Notes = "Urgent delivery requested", Status = OrderStatus.Dispatched, SubmittedDate = new DateTime(2023, 7, 30, 08, 15, 15), UpdatedDate = new DateTime(2023, 7, 30, 08, 15, 15) },
                new Order { Id = 10, CustomerId = 10, Notes = "Please package discreetly", Status = OrderStatus.Pending, SubmittedDate = new DateTime(2023, 7, 31, 17, 40, 05), UpdatedDate = new DateTime(2023, 7, 31, 17, 40, 05) }
            );

            builder.Entity<OrderDetail>().HasData(
                new OrderDetail { Id = 1, OrderId = 1, ProductId = 1, UnitPrice = 10.32, Quantity = 10 },
                new OrderDetail { Id = 2, OrderId = 1, ProductId = 3, UnitPrice = 200.00, Quantity = 1 },
                new OrderDetail { Id = 4, OrderId = 2, ProductId = 4, UnitPrice = 22.00, Quantity = 2 },
                new OrderDetail { Id = 5, OrderId = 2, ProductId = 5, UnitPrice = 50.00, Quantity = 1 },
                new OrderDetail { Id = 6, OrderId = 3, ProductId = 6, UnitPrice = 35.75, Quantity = 3 },
                new OrderDetail { Id = 7, OrderId = 3, ProductId = 7, UnitPrice = 18.20, Quantity = 2 },
                new OrderDetail { Id = 8, OrderId = 3, ProductId = 1, UnitPrice = 10.32, Quantity = 1 },
                new OrderDetail { Id = 9, OrderId = 4, ProductId = 8, UnitPrice = 42.50, Quantity = 1 },
                new OrderDetail { Id = 10, OrderId = 5, ProductId = 9, UnitPrice = 55.00, Quantity = 2 },
                new OrderDetail { Id = 11, OrderId = 5, ProductId = 3, UnitPrice = 200.00, Quantity = 1 },
                new OrderDetail { Id = 12, OrderId = 6, ProductId = 10, UnitPrice = 60.00, Quantity = 4 },
                new OrderDetail { Id = 13, OrderId = 7, ProductId = 2, UnitPrice = 15.50, Quantity = 3 },
                new OrderDetail { Id = 14, OrderId = 7, ProductId = 4, UnitPrice = 22.00, Quantity = 1 },
                new OrderDetail { Id = 15, OrderId = 7, ProductId = 6, UnitPrice = 35.75, Quantity = 2 },
                new OrderDetail { Id = 16, OrderId = 8, ProductId = 5, UnitPrice = 50.00, Quantity = 1 },
                new OrderDetail { Id = 17, OrderId = 8, ProductId = 7, UnitPrice = 18.20, Quantity = 1 },
                new OrderDetail { Id = 18, OrderId = 9, ProductId = 1, UnitPrice = 10.32, Quantity = 2 },
                new OrderDetail { Id = 19, OrderId = 9, ProductId = 8, UnitPrice = 42.50, Quantity = 1 },
                new OrderDetail { Id = 20, OrderId = 9, ProductId = 10, UnitPrice = 60.00, Quantity = 3 },
                new OrderDetail { Id = 21, OrderId = 10, ProductId = 9, UnitPrice = 55.00, Quantity = 1 }
            );

        }
    }
}

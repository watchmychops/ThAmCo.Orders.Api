﻿namespace ThAmCo.Orders.Api.Data {
    public class OrderDetail {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public Product Product { get; set; }
    }
}
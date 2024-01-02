namespace ThAmCo.Orders.Api.Data {
    public class Order {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public OrderStatus Status { get; set; }
        public string Notes { get; set; } = null!;
        public DateTime SubmittedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public List<OrderDetail> OrderDetails { get; set; } = null!;
    }
}
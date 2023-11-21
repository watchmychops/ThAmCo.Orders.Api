namespace ThAmCo.Orders.Api.Data {
    public class Order {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime SubmittedDate { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
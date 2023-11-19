namespace ThAmCo.Orders.Api.Data {
    public class Order {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime SubmittedDate { get; set; }
    }
}
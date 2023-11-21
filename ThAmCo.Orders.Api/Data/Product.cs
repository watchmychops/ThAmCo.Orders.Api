namespace ThAmCo.Orders.Api.Data {
    public class Product {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required Product Description { get; set; }
    }
}
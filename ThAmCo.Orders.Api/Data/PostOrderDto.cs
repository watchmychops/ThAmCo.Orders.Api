using System.ComponentModel.DataAnnotations;
using ThAmCo.Orders.Api.Data;

namespace ThAmCo.Orders.Api {
    public class PostOrderDto {
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public DateTime SubmittedDate { get; set; }
        public string Notes { get; set; } = null!;
        [Required]
        public required List<OrderDetailDto> OrderDetails { get; set; }
    }
}
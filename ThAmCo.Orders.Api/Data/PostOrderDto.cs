using System.ComponentModel.DataAnnotations;
using ThAmCo.Orders.Api.Data;

namespace ThAmCo.Orders.Api.Controllers {
    public class PostOrderDto {
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public DateTime SubmittedDate { get; set; }
        [Required]
        public required List<OrderDetailDto> OrderDetails { get; set; }
    }
}
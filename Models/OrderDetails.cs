using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationSports.Models
{
    public class OrderDetails
    {

        [Key]
        public int OrderDetailID { get; set; }

        [ForeignKey("Order")]

        public int OrderID { get; set; }
        [ForeignKey("Purchase")]

        public int PurchaseID { get; set; }

        [Range(1, 100)]
        [Required]
        public int Quantity { get; set; }

        [Range(1, 1000000)]
        [Required]
        public decimal Price { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }


        [ValidateNever]
        public Order Order { get; set; }

        [ValidateNever]
        public Purchase Purchase { get; set; }
    }
}

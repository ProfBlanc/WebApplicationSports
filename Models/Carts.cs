using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationSports.Models
{
    public class Carts
    {

        [Key]
        public int CartID { get; set; }

        [ForeignKey("Purchase")]

        public int PurchaseID { get; set; }

        [Range(1, 100)]
        [Required]
        public int Quantity { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }


        [ValidateNever]
        public Purchase Purchase { get; set; }
    }
}

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationSports.Models
{
    public class Purchase
    {
        [Key]
        public int PurchaseId { get; set; }

        [ForeignKey("Seat")]
        public int SeatId { get; set; }

        [ForeignKey("IdentityUser")]
        public string UserId { get; set; }
        [Required]
        public string PaymentMethod { get; set; }

        [ValidateNever]

        public IdentityUser IdentityUser { get; set; }

        [ValidateNever]
        public Seat Seat { get; set; }
    }
}

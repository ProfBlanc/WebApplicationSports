using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationSports.Models
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }
        [Required]
        public string PlayerName { get; set; }

        [Required]
        public int PlayerNumber { get; set; }

        [Required]
        public int TeamId { get; set; }

        [ValidateNever]
        public Team Team { get; set; }

    }
}

using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace WebApplicationSports.Models
{
    public class Team
    {
        [Key]
        public int TeamId { get; set; }
        [Required]
        public string TeamName { get; set; }
        [Required]
        public string City{ get; set; }
        [Required]
        public string Region { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]

        [NotMapped]
        public IFormFile LogoUpload { get; set; }

        [ValidateNever]
        public string Logo { get; set; }
        [Required]
        public string MascotName { get; set; }


    }
}

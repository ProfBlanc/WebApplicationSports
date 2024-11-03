using System.ComponentModel.DataAnnotations;

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
        public string Logo { get; set; }
        [Required]
        public string MascotName { get; set; }


    }
}

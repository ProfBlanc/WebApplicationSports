using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationSports.Models
{
    public class Seat
    {
        [Key]
        public int SeatId { get; set; }

        [ForeignKey("Game")]
        public int GameId { get; set; }
        [Required]
        public int SeatRow { get; set; }

        [Required]
        public int SeatNumber { get; set; }

        [Required]
       public decimal Price { get; set; }

        [ValidateNever]
        public Game Game { get; set; }
    }
}

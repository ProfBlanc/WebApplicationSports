using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationSports.Models
{
    public class Game
    {
        [Key]
        public int GameId {get;set;}

        [Required]
        public DateTime DateOfMatch{get;set;}

        [ForeignKey("Team")]
        public int TeamHome { get; set; }

        [Required]
        public int HomeScore { get; set; }
        
        [ForeignKey("Team")]
        public int TeamAway { get; set; }

        [Required]
        public int AwayScore { get; set; }

        [ValidateNever]
        public Team Team1 { get; set; }
        [ValidateNever]
        public Team Team2 { get; set; }

    }
}

using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.Build.Framework;

namespace bme_fon_vulyra.Data.Models
{
    public class Player
    {
        [Required]
        public Guid? Id { get; set; }

        [Required]
        [ForeignKey(nameof(Tournament))]
        public Guid? TournamentId { get; set; }
        public Tournament? Tournament { get; set; }
    }
}

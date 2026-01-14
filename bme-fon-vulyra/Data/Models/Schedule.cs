using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.Build.Framework;

namespace bme_fon_vulyra.Data.Models
{
    public class Schedule
    {
        [Required]
        public Guid? Id { get; set; }

        [Required]
        [ForeignKey(nameof(Player))]
        public Guid? PlayerId { get; set; }
        public Player? Player { get; set; }
    }
}

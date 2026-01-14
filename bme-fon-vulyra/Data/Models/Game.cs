using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.Build.Framework;

namespace bme_fon_vulyra.Data.Models
{
    public class Game
    {
        [Required]
        public Guid? Id { get; set; }

        [Required]
        [ForeignKey(nameof(Schedule))]
        public Guid? ScheduleId { get; set; }
        public Schedule? Schedule { get; set; }
    }
}

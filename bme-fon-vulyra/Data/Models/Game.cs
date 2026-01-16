using System.ComponentModel.DataAnnotations;

using bme_fon_vulyra.Data.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace bme_fon_vulyra.Data.Models
{
    public class Game : IEntity, IAuditable
    {
        public Guid Id { get; set; }

        [Required]
        [ForeignKey(nameof(Schedule))]
        public Guid? ScheduleId { get; set; }
        public virtual Schedule? Schedule { get; set; }
        public DateTimeOffset? CreatedOn { get; set; }
    }
}

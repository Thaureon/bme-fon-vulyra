using bme_fon_vulyra.Data.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bme_fon_vulyra.Data.Models
{
    public class Schedule : IEntity, IAuditable
    {
        public Guid Id { get; set; }

        [Required]
        [ForeignKey(nameof(Player))]
        public Guid? PlayerId { get; set; }
        public virtual Player? Player { get; set; }
        public DateTimeOffset? CreatedOn { get; set; }
    }
}

using bme_fon_vulyra.Data.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bme_fon_vulyra.Data.Models
{
    public class Player : IEntity, IAuditable
    {
        public Guid Id { get; set; }

        [Required]
        [ForeignKey(nameof(Tournament))]
        public Guid? TournamentId { get; set; }
        public virtual Tournament? Tournament { get; set; }

        public DateTimeOffset? CreatedOn { get; set; }
    }
}

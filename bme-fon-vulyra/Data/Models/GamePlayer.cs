using bme_fon_vulyra.Data.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bme_fon_vulyra.Data.Models
{
    public class GamePlayer : IEntity, IAuditable
    {
        public Guid Id { get; set; }

        public int Score { get; set; }

        [Required]
        [ForeignKey(nameof(Game))]
        public Guid? GameId { get; set; }
        public virtual Game? Game { get; set; }

        [Required]
        [ForeignKey(nameof(Player))]
        public Guid? PlayerId { get; set; }
        public virtual Player? Player { get; set; }
        public DateTimeOffset? CreatedOn { get; set; }
    }
}

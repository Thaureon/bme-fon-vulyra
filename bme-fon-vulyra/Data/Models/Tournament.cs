using System.ComponentModel.DataAnnotations;

using bme_fon_vulyra.Data.Enums;
using bme_fon_vulyra.Data.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace bme_fon_vulyra.Data.Models
{
    public class Tournament : IEntity, IAuditable
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public TournamentType TournamentType { get; set; }

        [Required]
        [ForeignKey(nameof(Account))]
        public Guid? AccountId { get; set; }
        public virtual Account? Account { get; set; }

        public DateTimeOffset? CreatedOn { get; set; }
    }
}

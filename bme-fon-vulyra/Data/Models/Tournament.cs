using bme_fon_vulyra.Data.Interfaces;

namespace bme_fon_vulyra.Data.Models
{
    public class Tournament : IEntity, IAuditable
    {
        public Guid Id { get; set; }

        //User who owns this
        public string Name { get; set; }
        public string TournamentType { get; set; }

        public DateTimeOffset? CreatedOn { get; set; }
    }
}

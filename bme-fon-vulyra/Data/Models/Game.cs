using bme_fon_vulyra.Data.Interfaces;

namespace bme_fon_vulyra.Data.Models
{
    public class Game : IEntity, IAuditable
    {
        public Guid Id { get; set; }
        public DateTimeOffset? CreatedOn { get; set; }
    }
}

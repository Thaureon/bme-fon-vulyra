using bme_fon_vulyra.Data.Interfaces;

namespace bme_fon_vulyra.Data.Models
{
    public class Account : IEntity, IAuditable
    {
        public Guid Id { get; set; }

        public string UserId { get; set; }
        public string UserName { get; set; }

        public DateTimeOffset? CreatedOn { get; set; }
    }
}

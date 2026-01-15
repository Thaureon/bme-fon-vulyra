using System.ComponentModel.DataAnnotations;

namespace bme_fon_vulyra.Data.Interfaces
{
    public interface IEntity
    {
        [Key]
        Guid Id { get; set; }
    }
}

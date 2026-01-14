using System.ComponentModel.DataAnnotations;

namespace bme_fon_vulyra.Data.Models
{
    public class Tournament
    {
        [Required]
        public Guid? Id { get; set; }
    }
}

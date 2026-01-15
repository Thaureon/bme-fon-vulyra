using System.ComponentModel.DataAnnotations;

namespace bme_fon_vulyra.Data.Models
{
    public class Game
    {
        [Required]
        public Guid? Id { get; set; }
    }
}

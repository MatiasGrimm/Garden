using System.ComponentModel.DataAnnotations;

namespace MyGarden.Models.Entities
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;
    }
}

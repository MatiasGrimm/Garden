using MyGarden.API.Models.Entities.Enums;
using MyGarden.Models.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyGarden.API.Models.Entities
{
    public class GardenAccess
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        public Guid UserID { get; set; }
        
        public User User { get; set; } = null!;

        public Access Access { get; set; }

        public Guid GardenID { get; set; }

        public Garden Garden { get; set; } = null!;
    }
}

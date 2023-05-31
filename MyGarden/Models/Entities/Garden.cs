using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyGarden.API.Models.Entities
{
    public class Garden : IDisabledEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Address { get; set; }

        public bool IsPublic { get; set; }

        public bool IsDisabled { get; set; }

        public List<GardenAccess> GardenAccess { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace MyGarden.API.Models.Entities
{
    public class Watering
    {
        [Key]
        public Guid id { get; set; }
    }
}

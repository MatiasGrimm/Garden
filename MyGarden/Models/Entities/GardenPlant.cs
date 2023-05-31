using System;

namespace MyGarden.API.Models.Entities
{
    public class GardenPlant
    {
        public Guid Id { get; set; }

        public Guid GardenID { get; set; }

        public Guid PlantID { get; set; }

        public string Notes { get; set; }
    }
}

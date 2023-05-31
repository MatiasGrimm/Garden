using System;

namespace MyGarden.API.Models.Entities
{
    public interface IDatedEntity
    {
        public DateTimeOffset Created { get; set; }

        public DateTimeOffset Updated { get; set; }
    }
}

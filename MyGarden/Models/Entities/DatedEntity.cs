using System;

namespace MyGarden.API.Models.Entities
{
    public abstract class DatedEntity : IDatedEntity
    {
        public DateTimeOffset Created { get; set; }

        public DateTimeOffset Updated { get; set; }
    } 
}

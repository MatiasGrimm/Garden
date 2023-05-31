using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using MyGarden.API.Models.Entities;

namespace MyGarden.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions options) : base(options)
        {
            SavingChanges += ApiDbContext_SavingChanges;
        }


        private void ApiDbContext_SavingChanges(object? sender, SavingChangesEventArgs e)
        {
            UpdateCreatedChanged();
        }

        private void UpdateCreatedChanged()
        {
            var now = DateTimeOffset.Now;
            foreach (var entry in ChangeTracker.Entries<IDatedEntity>())
            {
                var entity = entry.Entity;
                switch (entry.State)
                {
                    case EntityState.Added:
                        entity.Created = now;
                        entity.Updated = now;
                        break;

                    case EntityState.Modified:
                        entity.Updated = now;
                        break;
                }
            }

            ChangeTracker.DetectChanges();
        }
    }
}

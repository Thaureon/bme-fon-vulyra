using Microsoft.EntityFrameworkCore;

namespace bme_fon_vulyra.Data.Helpers
{
    public static class ContextExtensions
    {
        public static void AddRemoveOneToManyCascadeConvention(this ModelBuilder builder)
        {
            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                entityType.GetForeignKeys()
                    .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade)
                    .ToList()
                    .ForEach(fk => fk.DeleteBehavior = DeleteBehavior.Restrict);
            }
        }
    }
}

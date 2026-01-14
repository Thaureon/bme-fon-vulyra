using bme_fon_vulyra.Data.Models;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace bme_fon_vulyra.Data
{
    //$env:ASPNETCORE_ENVIRONMENT='Local'
    //dotnet ef migrations add V1 -c VulyraContext --verbose
    //dotnet ef database update -c VulyraContext --verbose
    //dotnet ef migrations remove -c VulyraContext --verbose

    public class VulyraContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Game> Games { get; set; }

        public VulyraContext()
        {
        }

        public VulyraContext(string connectionString) : base(new DbContextOptionsBuilder().UseSqlServer(connectionString).Options)
        {
        }

        public VulyraContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //if (modelBuilder == null)
            //    throw new ArgumentNullException("modelBuilder");

            //modelBuilder.AddRemoveOneToManyCascadeConvention();

            //modelBuilder.ApplyConventions();

            //base.OnModelCreating(modelBuilder);
        }
    }
}

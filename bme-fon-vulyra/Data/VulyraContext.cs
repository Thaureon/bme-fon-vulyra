using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace bme_fon_vulyra.Data
{
    //$env:ASPNETCORE_ENVIRONMENT='Local'
    //dotnet ef migrations add V1 -c VulyraContext --verbose
    //dotnet ef database update -c VulyraContext --verbose
    //dotnet ef migrations remove -c VulyraContext --verbose

    public class VulyraContext(DbContextOptions<VulyraContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
    }
}

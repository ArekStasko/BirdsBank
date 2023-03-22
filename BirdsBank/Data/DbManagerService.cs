using Microsoft.EntityFrameworkCore;

namespace BirdsBank.Data;

public class DbManagerService
{
    public static void MigrationInitialization(IApplicationBuilder app)
    {
        using (var serviceScope = app.ApplicationServices.CreateScope())
        {
            serviceScope.ServiceProvider.GetService<AppDbContext>().Database.Migrate();
        }
    }
}
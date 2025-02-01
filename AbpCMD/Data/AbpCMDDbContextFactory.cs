using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace AbpCMD.Data;

public class AbpCMDDbContextFactory : IDesignTimeDbContextFactory<AbpCMDDbContext>
{
    public AbpCMDDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<AbpCMDDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new AbpCMDDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
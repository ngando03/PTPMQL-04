using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace tinhchisoMBI.Data
{
    public class ApplicationDbcontextFactory : IDesignTimeDbContextFactory<ApplicationDbcontext>
    {
        public ApplicationDbcontext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) // nơi đặt file appsettings.json
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbcontext>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("chisoBMI"));

            return new ApplicationDbcontext(optionsBuilder.Options);
        }
    }
}

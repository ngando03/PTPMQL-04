using Microsoft.EntityFrameworkCore;
using tinhchisoMBI.Models;

namespace tinhchisoMBI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Person { get; set; }  // Thêm bảng của bạn ở đây
    }
}
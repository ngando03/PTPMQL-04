using Microsoft.EntityFrameworkCore;
using tinhchisoMBI.Models;

namespace tinhchisoMBI.Data
{
    public class ApplicationDbcontext : DbContext 
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options)
        {

        }
        public DbSet<Person> Person { get; set; }
        
    }
    

}
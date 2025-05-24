using Microsoft.EntityFrameworkCore;
using System;
using tinhchisoMBI.Models;

namespace tinhchisoMBI.Data
{
    public class ApplicationDbcontext : DbContext
    {
        private readonly ApplicationDbcontext _context;

        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options)
        {

        }
        public DbSet<chisoBMI> Person { get; set; }

    }


}
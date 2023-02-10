using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CodeFr.Models
{
    public class CompanyContext : DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options)
        {
        }

        public DbSet<Information> Information { get; set; }
    }
}

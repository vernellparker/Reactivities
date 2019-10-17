using System;
using Microsoft.EntityFrameworkCore;
using Domain;
using Microsoft.Extensions.Configuration;

namespace Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Value> Values { get; set; }

    }
}

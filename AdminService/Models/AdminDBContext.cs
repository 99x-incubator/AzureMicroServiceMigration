using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminService.Models
{
    public class AdminDBContext : DbContext
    {
        public AdminDBContext(DbContextOptions<AdminDBContext> options)
            : base(options)
        { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<SystemUser> SystemUsers { get; set; }
    }
}

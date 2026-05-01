using Microsoft.EntityFrameworkCore;
using MVVMSQliteLab.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVVMSQliteLab.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=helloapp.db");
        }
    }
}

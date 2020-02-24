using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PIV_2
{
    public class Context : DbContext
    {
        public DbSet<Zajecia> Zajecias { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source = DESKTOP - P79SPUU\MICHALG; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");

        }

      //  protected override void OnModelCreating(ModelBuilder modelBuilder)
      //  {
      //      base.OnModelCreating(modelBuilder);
      //      modelBuilder.Entity<Zajecia>().HasKey(x => x.Id);
       //     modelBuilder.Entity<Zajecia>().Property(x => x.Nazwa).IsRequired();
      //  }
    }
}

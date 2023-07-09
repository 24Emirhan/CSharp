using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arac_Satis.Model
{
    public class AracDbContext : DbContext
    {

        public DbSet<Araba> Arabalar { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=AracDB; Integrated Security=true; TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Araba>(entity =>
            {
                entity.ToTable("tblArac");
                entity.Property(a => a.Marka).HasDefaultValue("marka").HasColumnType("varchar").HasMaxLength(200).IsRequired();
                entity.Property(a => a.Model).HasDefaultValue("model").HasColumnType("varchar").HasMaxLength(200).IsRequired();
            });


            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("tblUser");
                entity.Property(k => k.UserName).HasDefaultValue("UserName").HasColumnType("varchar").HasMaxLength(20).IsRequired();
                entity.Property(k => k.Password).HasDefaultValue("Password").HasColumnType("varchar").HasMaxLength(20).IsRequired();
            });
        }

    }
}

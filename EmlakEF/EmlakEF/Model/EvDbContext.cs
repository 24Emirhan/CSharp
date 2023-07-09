using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakEF.Model
{
    public class EvDbContext : DbContext
    {

        public DbSet<Ev> Evler { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=CDB; Integrated Security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Ev>(entity =>
            {
                entity.ToTable("tblEmlak");
                entity.Property(e => e.Semt).HasDefaultValue("semt").HasColumnType("varchar").HasMaxLength(200).IsRequired();
                entity.Property(e => e.Alan).HasDefaultValue("alan").HasColumnType("varchar").HasMaxLength(200).IsRequired();
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

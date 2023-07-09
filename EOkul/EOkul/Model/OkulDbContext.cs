using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOkul.Model
{
    public class OkulDbContext : DbContext
    {
        public DbSet<Kullanici> Kullaniciler{ get; set; }
        public DbSet<Ders> Dersler{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=E_OkulDB; Integrated Security=true; TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Kullanici>(entity =>
            {
                entity.ToTable("tblKullanici");
                entity.Property(k => k.KullaniciAdi).HasDefaultValue("KullaniciAdi").HasColumnType("varchar").HasMaxLength(200).IsRequired();
                entity.Property(k => k.Sifre).HasDefaultValue("Sifre").HasColumnType("varchar").HasMaxLength(30).IsRequired();
            });


            modelBuilder.Entity<Ders>(entity =>
            {
                entity.ToTable("tblDers");
                entity.Property(d => d.Adi).HasDefaultValue("Adi").HasColumnType("varchar").HasMaxLength(20).IsRequired();
                entity.Property(d => d.Numarasi).HasDefaultValue("Numarasi").HasColumnType("varchar").HasMaxLength(20).IsRequired();
            });
        }
    }
}

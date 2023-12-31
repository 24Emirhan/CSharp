﻿// <auto-generated />
using EmlakEF.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmlakEF.Migrations
{
    [DbContext(typeof(EvDbContext))]
    [Migration("20230106162903_firstMg")]
    partial class firstMg
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmlakEF.Model.Ev", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Alan")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)")
                        .HasDefaultValue("alan");

                    b.Property<int>("IlanNo")
                        .HasColumnType("int");

                    b.Property<int>("KatNo")
                        .HasColumnType("int");

                    b.Property<int>("OdaSayisi")
                        .HasColumnType("int");

                    b.Property<string>("Semt")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)")
                        .HasDefaultValue("semt");

                    b.HasKey("Id");

                    b.ToTable("tblEmlak");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using MicroserviciosPrueba2;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MicroserviciosPrueba2.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("MicroserviciosPrueba2.ParkingDat", b =>
                {
                    b.Property<string>("nombre")
                        .HasColumnType("text");

                    b.Property<string>("colorSel")
                        .HasColumnType("text");

                    b.Property<int>("nplazascoche")
                        .HasColumnType("integer");

                    b.Property<int>("nplazasmoto")
                        .HasColumnType("integer");

                    b.HasKey("nombre");

                    b.ToTable("ParkingDats");
                });
#pragma warning restore 612, 618
        }
    }
}

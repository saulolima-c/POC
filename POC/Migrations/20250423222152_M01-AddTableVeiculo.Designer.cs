﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using POC.Models;

#nullable disable

namespace POC.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250423222152_M01-AddTableVeiculo")]
    partial class M01AddTableVeiculo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("POC.Models.Veiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AnoFabricacao")
                        .HasColumnType("int");

                    b.Property<int>("AnoModelo")
                        .HasColumnType("int");

                    b.Property<int>("Nome")
                        .HasColumnType("int");

                    b.Property<int>("Placa")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Veículos");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebApiEmptransporte.Models;

namespace WebApiEmptransporte.Migrations
{
    [DbContext(typeof(CrudTransporteContext))]
    partial class CrudTransporteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("WebApiEmptransporte.Models.Conductor", b =>
                {
                    b.Property<int>("Id_Conductor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Apellido")
                        .HasColumnType("text");

                    b.Property<string>("CC")
                        .HasColumnType("text");

                    b.Property<string>("Date")
                        .HasColumnType("text");

                    b.Property<string>("Id_vehiculo")
                        .HasColumnType("text");

                    b.Property<string>("Nombre")
                        .HasColumnType("text");

                    b.HasKey("Id_Conductor");

                    b.ToTable("conductors");
                });

            modelBuilder.Entity("WebApiEmptransporte.Models.Propietarios", b =>
                {
                    b.Property<int>("PropietarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Apellido")
                        .HasColumnType("text");

                    b.Property<int>("Cedula")
                        .HasColumnType("integer");

                    b.Property<string>("Ciudad")
                        .HasColumnType("text");

                    b.Property<string>("Nombre")
                        .HasColumnType("text");

                    b.Property<string>("Telefono")
                        .HasColumnType("text");

                    b.HasKey("PropietarioId");

                    b.ToTable("Propietario");
                });

            modelBuilder.Entity("WebApiEmptransporte.Models.Vehiculo", b =>
                {
                    b.Property<int>("Id_vehiculo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Fecha")
                        .HasColumnType("text");

                    b.Property<string>("Id_propietario")
                        .HasColumnType("text");

                    b.Property<string>("Marca")
                        .HasColumnType("text");

                    b.Property<string>("Modelo")
                        .HasColumnType("text");

                    b.Property<string>("Placa")
                        .HasColumnType("text");

                    b.HasKey("Id_vehiculo");

                    b.ToTable("vehiculos");
                });
#pragma warning restore 612, 618
        }
    }
}
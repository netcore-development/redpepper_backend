﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RedPepper.API.Data;

namespace RedPepper.API.Migrations
{
    [DbContext(typeof(DbContextPostgreSql))]
    partial class DbContextPostgreSqlModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("RedPepper.API.Model.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IdPersona");

                    b.Property<int?>("PersonaId");

                    b.HasKey("Id");

                    b.HasIndex("PersonaId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("RedPepper.API.Model.Empleado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IdPersona");

                    b.Property<int?>("PersonaId");

                    b.HasKey("Id");

                    b.HasIndex("PersonaId");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("RedPepper.API.Model.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("CorreoElectronico")
                        .HasMaxLength(100);

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("Dui")
                        .HasMaxLength(10);

                    b.Property<DateTime>("FechaNacimiento");

                    b.Property<string>("Nit")
                        .HasMaxLength(17);

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Sexo")
                        .HasMaxLength(1);

                    b.Property<string>("Telefono")
                        .HasMaxLength(9);

                    b.HasKey("Id");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("RedPepper.API.Model.Cliente", b =>
                {
                    b.HasOne("RedPepper.API.Model.Persona", "Persona")
                        .WithMany()
                        .HasForeignKey("PersonaId");
                });

            modelBuilder.Entity("RedPepper.API.Model.Empleado", b =>
                {
                    b.HasOne("RedPepper.API.Model.Persona", "Persona")
                        .WithMany()
                        .HasForeignKey("PersonaId");
                });
#pragma warning restore 612, 618
        }
    }
}

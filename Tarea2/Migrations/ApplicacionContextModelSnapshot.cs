﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tarea2;

namespace Tarea2.Migrations
{
    [DbContext(typeof(ApplicacionContext))]
    partial class ApplicacionContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Tarea2.Panaderia", b =>
                {
                    b.Property<int>("PanaderiaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PanaderiaId");

                    b.ToTable("Panaderia");
                });

            modelBuilder.Entity("Tarea2.Producto", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Calorias")
                        .HasColumnType("real");

                    b.Property<string>("Ingredientes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PanaderiaProductosPanaderiaId")
                        .HasColumnType("int");

                    b.HasKey("ProductoId");

                    b.HasIndex("PanaderiaProductosPanaderiaId");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Tarea2.ProductoPanaderia", b =>
                {
                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.Property<int>("PanaderiaId")
                        .HasColumnType("int");

                    b.HasKey("ProductoId", "PanaderiaId");

                    b.HasIndex("PanaderiaId");

                    b.ToTable("ProductoPanaderia");
                });

            modelBuilder.Entity("Tarea2.Producto", b =>
                {
                    b.HasOne("Tarea2.Panaderia", "PanaderiaProductos")
                        .WithMany()
                        .HasForeignKey("PanaderiaProductosPanaderiaId");
                });

            modelBuilder.Entity("Tarea2.ProductoPanaderia", b =>
                {
                    b.HasOne("Tarea2.Panaderia", "Panaderia")
                        .WithMany("ProductoPanaderia")
                        .HasForeignKey("PanaderiaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tarea2.Producto", "Producto")
                        .WithMany("ProductoPanaderia")
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

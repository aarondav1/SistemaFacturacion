﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaFacturacionWebApiREST;

#nullable disable

namespace SistemaFacturacionWebApiREST.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Modelo.Entidades.Ciudad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_Ciudad");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Nombre_Ciu");

                    b.HasKey("Id");

                    b.ToTable("Ciudad");
                });

            modelBuilder.Entity("Modelo.Entidades.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_Cliente");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Cedula")
                        .HasColumnType("int");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdCiudad")
                        .HasColumnType("int")
                        .HasColumnName("ID_Ciudad");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ruc")
                        .HasColumnType("int");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdCiudad");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Modelo.Entidades.DetalleFactura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_Detalle_Factura");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("IdFactura")
                        .HasColumnType("int")
                        .HasColumnName("ID_Factura");

                    b.Property<int>("IdServicio")
                        .HasColumnType("int")
                        .HasColumnName("ID_Servicio");

                    b.Property<decimal>("PrecioPagar")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("Precio_Pagar");

                    b.HasKey("Id");

                    b.HasIndex("IdFactura");

                    b.HasIndex("IdServicio");

                    b.ToTable("Detalle_Factura");
                });

            modelBuilder.Entity("Modelo.Entidades.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_Empresa");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Descripcion_Emp");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("Modelo.Entidades.Factura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_Factura");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_Cliente");

                    b.Property<int>("IdEmpresa")
                        .HasColumnType("int")
                        .HasColumnName("ID_Empresa");

                    b.Property<int>("IdPago")
                        .HasColumnType("int")
                        .HasColumnName("ID_Pago");

                    b.HasKey("Id");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdEmpresa");

                    b.HasIndex("IdPago");

                    b.ToTable("Factura");
                });

            modelBuilder.Entity("Modelo.Entidades.Pago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_Pago");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("TipoPago")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Tipo_Pago");

                    b.HasKey("Id");

                    b.ToTable("Pago");
                });

            modelBuilder.Entity("Modelo.Entidades.Reembolso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_Reembolso");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Descripcion_Re");

                    b.Property<int>("IdFactura")
                        .HasColumnType("int")
                        .HasColumnName("ID_Factura");

                    b.Property<int>("IdServicio")
                        .HasColumnType("int")
                        .HasColumnName("ID_Servicio");

                    b.HasKey("Id");

                    b.HasIndex("IdFactura");

                    b.HasIndex("IdServicio");

                    b.ToTable("Reembolso");
                });

            modelBuilder.Entity("Modelo.Entidades.Servicio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_Servicio");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripction")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Descripction_Servicio");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("Valor_Unit");

                    b.HasKey("Id");

                    b.ToTable("Servicio");
                });

            modelBuilder.Entity("Modelo.Entidades.Cliente", b =>
                {
                    b.HasOne("Modelo.Entidades.Ciudad", "Ciudad")
                        .WithMany()
                        .HasForeignKey("IdCiudad")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ciudad");
                });

            modelBuilder.Entity("Modelo.Entidades.DetalleFactura", b =>
                {
                    b.HasOne("Modelo.Entidades.Factura", "Factura")
                        .WithMany()
                        .HasForeignKey("IdFactura")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Entidades.Servicio", "Servicio")
                        .WithMany()
                        .HasForeignKey("IdServicio")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Factura");

                    b.Navigation("Servicio");
                });

            modelBuilder.Entity("Modelo.Entidades.Factura", b =>
                {
                    b.HasOne("Modelo.Entidades.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Entidades.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("IdEmpresa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Entidades.Pago", "Pago")
                        .WithMany()
                        .HasForeignKey("IdPago")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Empresa");

                    b.Navigation("Pago");
                });

            modelBuilder.Entity("Modelo.Entidades.Reembolso", b =>
                {
                    b.HasOne("Modelo.Entidades.Factura", "Factura")
                        .WithMany()
                        .HasForeignKey("IdFactura")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Entidades.Servicio", "Servicio")
                        .WithMany()
                        .HasForeignKey("IdServicio")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Factura");

                    b.Navigation("Servicio");
                });
#pragma warning restore 612, 618
        }
    }
}

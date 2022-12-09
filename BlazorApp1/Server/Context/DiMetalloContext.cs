﻿using System;
using System.Collections.Generic;
using BlazorApp1.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BlazorApp1.Server.Context
{
    public partial class DiMetalloContext : DbContext
    {
        public DiMetalloContext()
        {
        }

        public DiMetalloContext(DbContextOptions<DiMetalloContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<Cotizacione> Cotizaciones { get; set; } = null!;
        public virtual DbSet<Insumo> Insumos { get; set; } = null!;
        public virtual DbSet<MaquinasHerramienta> MaquinasHerramientas { get; set; } = null!;
        public virtual DbSet<MateriaPrima> MateriaPrimas { get; set; } = null!;
        public virtual DbSet<Ordencompra> Ordencompras { get; set; } = null!;
        public virtual DbSet<Ordentrabajo> Ordentrabajos { get; set; } = null!;
        public virtual DbSet<Personal> Personals { get; set; } = null!;
        public virtual DbSet<Proveedore> Proveedores { get; set; } = null!;
        public virtual DbSet<Repuesto> Repuestos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=localhost\\sqlexpress;trusted_connection=true;database=DiMetallo;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Corredor).IsUnicode(false);

                entity.Property(e => e.Cp)
                    .IsUnicode(false)
                    .HasColumnName("CP");

                entity.Property(e => e.Cuit).IsUnicode(false);

                entity.Property(e => e.Direccion).IsUnicode(false);

                entity.Property(e => e.Mail).IsUnicode(false);

                entity.Property(e => e.NombreContacto).IsUnicode(false);

                entity.Property(e => e.NombreEmpresa).IsUnicode(false);

                entity.Property(e => e.Observaciones).IsUnicode(false);

                entity.Property(e => e.RazonSocial).IsUnicode(false);

                entity.Property(e => e.Telefono).IsUnicode(false);
            });

            modelBuilder.Entity<Cotizacione>(entity =>
            {
                entity.ToTable("cotizaciones");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Alcance)
                    .IsUnicode(false)
                    .HasColumnName("alcance");

                entity.Property(e => e.Cantidad)
                    .IsUnicode(false)
                    .HasColumnName("cantidad");

                entity.Property(e => e.Cliente)
                    .IsUnicode(false)
                    .HasColumnName("cliente");

                entity.Property(e => e.Codigo)
                    .IsUnicode(false)
                    .HasColumnName("codigo");

                entity.Property(e => e.Color)
                    .IsUnicode(false)
                    .HasColumnName("color");

                entity.Property(e => e.Descripcion)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .HasColumnName("estado");

                entity.Property(e => e.Fechaentrega)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaentrega");

                entity.Property(e => e.Observaciones)
                    .IsUnicode(false)
                    .HasColumnName("observaciones");

                entity.Property(e => e.Planos)
                    .IsUnicode(false)
                    .HasColumnName("planos");

                entity.Property(e => e.Titulo)
                    .IsUnicode(false)
                    .HasColumnName("titulo");

                entity.Property(e => e.Tratamientosuperficial)
                    .IsUnicode(false)
                    .HasColumnName("tratamientosuperficial");

                entity.Property(e => e.Valordolar)
                    .IsUnicode(false)
                    .HasColumnName("valordolar");

                entity.Property(e => e.Valorpeso)
                    .IsUnicode(false)
                    .HasColumnName("valorpeso");
            });

            modelBuilder.Entity<Insumo>(entity =>
            {
                entity.ToTable("Insumo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Codigo).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Foto).IsUnicode(false);

                entity.Property(e => e.Nombre).IsUnicode(false);
            });

            modelBuilder.Entity<MaquinasHerramienta>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Asignacion).IsUnicode(false);

                entity.Property(e => e.Codigo).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.DescripcionMantenimiento).IsUnicode(false);

                entity.Property(e => e.Disposicion).IsUnicode(false);

                entity.Property(e => e.Estado).IsUnicode(false);

                entity.Property(e => e.FechaIngreso).HasColumnType("datetime");

                entity.Property(e => e.Marca).IsUnicode(false);

                entity.Property(e => e.MotivoDisposicion).IsUnicode(false);

                entity.Property(e => e.MotivoEstado).IsUnicode(false);

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.PeriodicidadMantenimiento).IsUnicode(false);
            });

            modelBuilder.Entity<MateriaPrima>(entity =>
            {
                entity.ToTable("MateriaPrima");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Codigo).IsUnicode(false);

                entity.Property(e => e.Nombre).IsUnicode(false);
            });

            modelBuilder.Entity<Ordencompra>(entity =>
            {
                entity.ToTable("ordencompra");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Archivo)
                    .IsUnicode(false)
                    .HasColumnName("archivo");

                entity.Property(e => e.Control)
                    .IsUnicode(false)
                    .HasColumnName("control");

                entity.Property(e => e.Especificacion)
                    .IsUnicode(false)
                    .HasColumnName("especificacion");

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .HasColumnName("estado");

                entity.Property(e => e.Identificador)
                    .IsUnicode(false)
                    .HasColumnName("identificador");
            });

            modelBuilder.Entity<Ordentrabajo>(entity =>
            {
                entity.ToTable("ordentrabajo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cantidad)
                    .IsUnicode(false)
                    .HasColumnName("cantidad");

                entity.Property(e => e.Cliente)
                    .IsUnicode(false)
                    .HasColumnName("cliente");

                entity.Property(e => e.Codigo)
                    .IsUnicode(false)
                    .HasColumnName("codigo");

                entity.Property(e => e.Descripcion)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Despiece)
                    .IsUnicode(false)
                    .HasColumnName("despiece");

                entity.Property(e => e.Especificaciones)
                    .IsUnicode(false)
                    .HasColumnName("especificaciones");

                entity.Property(e => e.Estado)
                    .IsUnicode(false)
                    .HasColumnName("estado");

                entity.Property(e => e.Fechaentrega)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaentrega");
                
                entity.Property(e => e.Fechas)
                    .IsUnicode(false)
                    .HasColumnName("fechas");

                entity.Property(e => e.Lugarentrega)
                    .IsUnicode(false)
                    .HasColumnName("lugarentrega");

                entity.Property(e => e.Observaciones)
                    .IsUnicode(false)
                    .HasColumnName("observaciones");

                entity.Property(e => e.Pedidofabrica)
                    .HasColumnType("datetime")
                    .HasColumnName("pedidofabrica");

                entity.Property(e => e.Planos)
                    .IsUnicode(false)
                    .HasColumnName("planos");
            });

            modelBuilder.Entity<Personal>(entity =>
            {
                entity.ToTable("Personal");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("apellido");

                entity.Property(e => e.Categoria)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("categoria");

                entity.Property(e => e.CondicionContractual)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("condicionContractual");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.Dni).HasColumnName("dni");

                entity.Property(e => e.Legajo).HasColumnName("legajo");

                entity.Property(e => e.Mail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mail");

                entity.Property(e => e.Nombres)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombres");

                entity.Property(e => e.PremioEstablecido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("premioEstablecido");

                entity.Property(e => e.Puesto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("puesto");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("telefono");
            });

            modelBuilder.Entity<Proveedore>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cp)
                    .IsUnicode(false)
                    .HasColumnName("CP");

                entity.Property(e => e.Cuit).IsUnicode(false);

                entity.Property(e => e.Direccion).IsUnicode(false);

                entity.Property(e => e.Mail).IsUnicode(false);

                entity.Property(e => e.NombreContacto).IsUnicode(false);

                entity.Property(e => e.NombreEmpresa).IsUnicode(false);

                entity.Property(e => e.Observaciones).IsUnicode(false);

                entity.Property(e => e.RazonSocial).IsUnicode(false);

                entity.Property(e => e.Telefono).IsUnicode(false);
            });

            modelBuilder.Entity<Repuesto>(entity =>
            {
                entity.ToTable("Repuesto");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Codigo).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Foto).IsUnicode(false);

                entity.Property(e => e.Nombre).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

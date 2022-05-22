﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PRACTICA_AEAE_3_Juan_Quiceno.Models
{
    public partial class FACTURASContext : DbContext
    {
        public FACTURASContext()
        {
        }

        public FACTURASContext(DbContextOptions<FACTURASContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblcategoriaProd> TblcategoriaProds { get; set; } = null!;
        public virtual DbSet<Tblcliente> Tblclientes { get; set; } = null!;
        public virtual DbSet<TbldetalleFactura> TbldetalleFacturas { get; set; } = null!;
        public virtual DbSet<Tblempleado> Tblempleados { get; set; } = null!;
        public virtual DbSet<TblestadoFactura> TblestadoFacturas { get; set; } = null!;
        public virtual DbSet<Tblfactura> Tblfacturas { get; set; } = null!;
        public virtual DbSet<Tblproducto> Tblproductos { get; set; } = null!;
        public virtual DbSet<Tblrole> Tblroles { get; set; } = null!;
        public virtual DbSet<Tblseguridad> Tblseguridads { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblcategoriaProd>(entity =>
            {
                entity.HasKey(e => e.IdCategoria)
                    .HasName("PK__TBLCATEG__A3C02A1041A5238A");

                entity.ToTable("TBLCATEGORIA_PROD");

                entity.Property(e => e.DtmFechaModifica).HasColumnType("datetime");

                entity.Property(e => e.StrDescripcion)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.StrUsuarioModifico)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tblcliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK__TBLCLIEN__D5946642D44F0132");

                entity.ToTable("TBLCLIENTES");

                entity.Property(e => e.DtmFechaModifica).HasColumnType("datetime");

                entity.Property(e => e.StrDireccion)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.StrEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrNombre)
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.StrTelefono)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StrUsuarioModifica)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbldetalleFactura>(entity =>
            {
                entity.HasKey(e => e.IdDetalle)
                    .HasName("PK__TBLDETAL__E43646A593D94BA5");

                entity.ToTable("TBLDETALLE_FACTURA");

                entity.HasOne(d => d.IdFacturaNavigation)
                    .WithMany(p => p.TbldetalleFacturas)
                    .HasForeignKey(d => d.IdFactura)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBLDETALLE_FACTURA_TBLFACTURA");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.TbldetalleFacturas)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBLDETALLE_FACTURA_TBLPRODUCTO");
            });

            modelBuilder.Entity<Tblempleado>(entity =>
            {
                entity.HasKey(e => e.IdEmpleado);

                entity.ToTable("TBLEMPLEADO");

                entity.Property(e => e.DtmFechaModifica).HasColumnType("datetime");

                entity.Property(e => e.DtmIngreso).HasColumnType("datetime");

                entity.Property(e => e.DtmRetiro).HasColumnType("datetime");

                entity.Property(e => e.StrDatosAdicionales).HasColumnName("strDatosAdicionales");

                entity.Property(e => e.StrDireccion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StrEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrNombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("strNombre");

                entity.Property(e => e.StrTelefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrUsuarioModifico)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdRolEmpleadoNavigation)
                    .WithMany(p => p.Tblempleados)
                    .HasForeignKey(d => d.IdRolEmpleado)
                    .HasConstraintName("FK_TBLEMPLEADO_TBLROLES");
            });

            modelBuilder.Entity<TblestadoFactura>(entity =>
            {
                entity.HasKey(e => e.IdEstadoFactura);

                entity.ToTable("TBLESTADO_FACTURA");

                entity.Property(e => e.StrDescripcion)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tblfactura>(entity =>
            {
                entity.HasKey(e => e.IdFactura)
                    .HasName("PK__TBLFACTU__50E7BAF1B0F2E5BE");

                entity.ToTable("TBLFACTURA");

                entity.Property(e => e.DtmFecha).HasColumnType("datetime");

                entity.Property(e => e.DtmFechaModifica).HasColumnType("datetime");

                entity.Property(e => e.StrUsuarioModifica)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Tblfacturas)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBLFACTURA_TBLCLIENTES");

                entity.HasOne(d => d.IdEmpleadoNavigation)
                    .WithMany(p => p.Tblfacturas)
                    .HasForeignKey(d => d.IdEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBLFACTURA_TBLEMPLEADO");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.Tblfacturas)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_TBLFACTURA_TBLESTADO_FACTURA");
            });

            modelBuilder.Entity<Tblproducto>(entity =>
            {
                entity.HasKey(e => e.IdProducto)
                    .HasName("PK__TBLPRODU__09889210A63187C7");

                entity.ToTable("TBLPRODUCTO");

                entity.Property(e => e.DtmFechaModifica).HasColumnType("datetime");

                entity.Property(e => e.StrCodigo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StrDetalle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrFoto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("strFoto");

                entity.Property(e => e.StrNombre)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.StrUsuarioModifica)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Tblproductos)
                    .HasForeignKey(d => d.IdCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TBLPRODUC__IdCat__440B1D61");
            });

            modelBuilder.Entity<Tblrole>(entity =>
            {
                entity.HasKey(e => e.IdRolEmpleado);

                entity.ToTable("TBLROLES");

                entity.Property(e => e.StrDescripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tblseguridad>(entity =>
            {
                entity.HasKey(e => e.IdSeguridad);

                entity.ToTable("TBLSEGURIDAD");

                entity.Property(e => e.DtmFechaModifica).HasColumnType("datetime");

                entity.Property(e => e.StrClave)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrUsuario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrUsuarioModifico)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEmpleadoNavigation)
                    .WithMany(p => p.Tblseguridads)
                    .HasForeignKey(d => d.IdEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBLSEGURIDAD_TBLEMPLEADO");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

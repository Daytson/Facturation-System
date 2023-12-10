using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Facturation_System.Models
{
    public partial class MVCCRUDContext : DbContext
    {
        public MVCCRUDContext()
        {
        }

        public MVCCRUDContext(DbContextOptions<MVCCRUDContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<Dfactura> Dfacturas { get; set; } = null!;
        public virtual DbSet<Hfactura> Hfacturas { get; set; } = null!;
        public virtual DbSet<Producto> Productos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("server=DESKTOP-FG6LRCR\\SQLEXPRESS; database=MVCCRUD; integrated security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.Idcliente)
                    .HasName("PK_Cliente");

                entity.ToTable("CLIENTES");

                entity.Property(e => e.Idcliente).HasColumnName("IDcliente");

                entity.Property(e => e.Ciudad).HasMaxLength(50);

                entity.Property(e => e.Correo).HasMaxLength(80);

                entity.Property(e => e.Direccion).HasMaxLength(80);

                entity.Property(e => e.Ididentificacion)
                    .HasMaxLength(25)
                    .HasColumnName("IDidentificacion");

                entity.Property(e => e.Imagen).HasColumnType("image");

                entity.Property(e => e.Monto).HasColumnName("MONTO");

                entity.Property(e => e.Nombre).HasMaxLength(80);

                entity.Property(e => e.Pais).HasMaxLength(50);

                entity.Property(e => e.RutaImagen).HasColumnType("text");

                entity.Property(e => e.Sector).HasMaxLength(50);

                entity.Property(e => e.Telefono01).HasMaxLength(20);

                entity.Property(e => e.Telefono02).HasMaxLength(20);
            });

            modelBuilder.Entity<Dfactura>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DFACTURA");

                entity.Property(e => e.Articulo)
                    .HasMaxLength(10)
                    .HasColumnName("ARTICULO");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.Cliente)
                    .HasMaxLength(10)
                    .HasColumnName("CLIENTE");

                entity.Property(e => e.Factura)
                    .HasMaxLength(10)
                    .HasColumnName("FACTURA");

                entity.Property(e => e.Fecha)
                    .HasMaxLength(8)
                    .HasColumnName("FECHA");

                entity.Property(e => e.Impuesto).HasColumnName("IMPUESTO");

                entity.Property(e => e.Montoporlinea).HasColumnName("MONTOPORLINEA");

                entity.Property(e => e.Preciodeventa).HasColumnName("PRECIODEVENTA");

                entity.Property(e => e.Secuencia)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SECUENCIA");
            });

            modelBuilder.Entity<Hfactura>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HFACTURA");

                entity.Property(e => e.Cliente)
                    .HasMaxLength(10)
                    .HasColumnName("CLIENTE");

                entity.Property(e => e.Factura)
                    .HasMaxLength(10)
                    .HasColumnName("FACTURA");

                entity.Property(e => e.Fecha)
                    .HasMaxLength(8)
                    .HasColumnName("FECHA");

                entity.Property(e => e.Impuesto).HasColumnName("IMPUESTO");

                entity.Property(e => e.Montofacturado).HasColumnName("MONTOFACTURADO");

                entity.Property(e => e.Subtotal).HasColumnName("SUBTOTAL");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PRODUCTOS");

                entity.Property(e => e.BarCode).HasMaxLength(50);

                entity.Property(e => e.Descripcion).HasMaxLength(80);

                entity.Property(e => e.Imagen).HasColumnType("image");

                entity.Property(e => e.Item).HasMaxLength(10);

                entity.Property(e => e.Ruta).HasColumnType("text");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

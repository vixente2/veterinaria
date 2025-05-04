using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ConexionDataBase.Models;

public partial class VetdbContext : DbContext
{
    public VetdbContext()
    {
    }

    public VetdbContext(DbContextOptions<VetdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Atencion> Atencions { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<FichaAtencion> FichaAtencions { get; set; }

    public virtual DbSet<Mascotum> Mascota { get; set; }

    public virtual DbSet<Rol> Rols { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }
    public object Mascotas { get; internal set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\sqlexpress;Database=vetdb;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Atencion>(entity =>
        {
            entity.HasKey(e => e.IdAtencion);

            entity.ToTable("Atencion");

            entity.Property(e => e.IdAtencion).HasColumnName("id_atencion");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.Observacion)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("observacion");
            entity.Property(e => e.Valor).HasColumnName("valor");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Atencions)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Atencion_Usuario");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Run);

            entity.ToTable("Cliente");

            entity.Property(e => e.Run)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("run");
            entity.Property(e => e.Apellido)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.Direccion)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.Email)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Fono).HasColumnName("fono");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<FichaAtencion>(entity =>
        {
            entity.HasKey(e => e.IdFicha);

            entity.ToTable("FichaAtencion");

            entity.Property(e => e.IdFicha).HasColumnName("id_ficha");
            entity.Property(e => e.Comentario)
                .IsUnicode(false)
                .HasColumnName("comentario");
            entity.Property(e => e.IdAtencion).HasColumnName("id_atencion");
            entity.Property(e => e.IdMascota).HasColumnName("id_mascota");
            entity.Property(e => e.Peso).HasColumnName("peso");

            entity.HasOne(d => d.IdAtencionNavigation).WithMany(p => p.FichaAtencions)
                .HasForeignKey(d => d.IdAtencion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FichaAtencion_Atencion");

            entity.HasOne(d => d.IdMascotaNavigation).WithMany(p => p.FichaAtencions)
                .HasForeignKey(d => d.IdMascota)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FichaAtencion_Mascota");
        });

        modelBuilder.Entity<Mascotum>(entity =>
        {
            entity.HasKey(e => e.IdMascota);

            entity.Property(e => e.IdMascota).HasColumnName("id_mascota");
            entity.Property(e => e.Edad).HasColumnName("edad");
            entity.Property(e => e.Especie)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("especie");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Raza)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("raza");
            entity.Property(e => e.Run)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("run");
            entity.Property(e => e.Sexo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sexo");

            entity.HasOne(d => d.RunNavigation).WithMany(p => p.Mascota)
                .HasForeignKey(d => d.Run)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Mascota_Cliente");
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.HasKey(e => e.IdRol);

            entity.ToTable("Rol");

            entity.Property(e => e.IdRol).HasColumnName("id_rol");
            entity.Property(e => e.Rol1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("rol");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUser);

            entity.ToTable("Usuario");

            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.IdRol).HasColumnName("id_rol");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Password)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("password");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdRol)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Usuario_Rol");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

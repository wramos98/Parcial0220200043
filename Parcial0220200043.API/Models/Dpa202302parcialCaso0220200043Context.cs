using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Parcial0220200043.API.Models;

public partial class Dpa202302parcialCaso0220200043Context : DbContext
{
    public Dpa202302parcialCaso0220200043Context()
    {
    }

    public Dpa202302parcialCaso0220200043Context(DbContextOptions<Dpa202302parcialCaso0220200043Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Country> Country { get; set; }

    public virtual DbSet<Territory> Territory { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=WS2302512;Database=DPA202302ParcialCaso0220200043;integrated security=true;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Country>(entity =>
        {
            entity.Property(e => e.Currency)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Territory>(entity =>
        {
            entity.Property(e => e.Area)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Population)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

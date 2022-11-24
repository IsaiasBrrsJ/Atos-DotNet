﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AtosEntityDataBaseFirst;

public partial class Contexto : DbContext
{
    public Contexto()
    {
    }

    public Contexto(DbContextOptions<Contexto> options)
        : base(options)
    {
    }

    public virtual DbSet<Email> Emails { get; set; }

    public virtual DbSet<Pessoa> Pessoas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string configBanco = @"Data Source=localhost;initial Catalog=AtosEntity2;User ID=AtosEntity2;password=admin123;language=Portuguese;Trusted_Connection=True;TrustServerCertificate=True;";

        optionsBuilder.UseSqlServer(configBanco);

        optionsBuilder.UseLazyLoadingProxies();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Email>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__Emails__3213E83FC8546F41");

            entity.Property(e => e.id).HasColumnName("id");
            entity.Property(e => e.email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FkPessoa).HasColumnName("fk_pessoa");

            entity.HasOne(d => d.FkPessoaNavigation).WithMany(p => p.Emails)
                .HasForeignKey(d => d.FkPessoa)
                .HasConstraintName("FK__Emails__fk_pesso__267ABA7A");
        });

        modelBuilder.Entity<Pessoa>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__Pessoas__3213E83FC98A5F72");

            entity.Property(e => e.id).HasColumnName("id");
            entity.Property(e => e.nome)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

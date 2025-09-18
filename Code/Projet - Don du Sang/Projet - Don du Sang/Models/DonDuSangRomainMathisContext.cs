using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Projet___Don_du_Sang.Models;

public partial class DonDuSangRomainMathisContext : DbContext
{
    public DonDuSangRomainMathisContext()
    {
    }

    public DonDuSangRomainMathisContext(DbContextOptions<DonDuSangRomainMathisContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Donneur> Donneurs { get; set; }

    public virtual DbSet<Question> Questions { get; set; }

    public virtual DbSet<Reponse> Reponses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=2a03:5840:111:1024:508f:fc67:4795:f4d3;User ID=sa;Password=erty64%;Database=DonDuSangRomainMathis;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Donneur>(entity =>
        {
            entity.HasKey(e => e.IdDonneur).HasName("PK__Donneur__F07704D9C01F2181");

            entity.ToTable("Donneur");

            entity.Property(e => e.IdDonneur).HasColumnName("Id_Donneur");
            entity.Property(e => e.AdresseMail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EstDaccord)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EstDAccord");
            entity.Property(e => e.MotDePasse)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nom)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Prenom)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Question>(entity =>
        {
            entity.HasKey(e => e.IdQuestion).HasName("PK__Question__B4902467CF35C681");

            entity.ToTable("Question");

            entity.Property(e => e.IdQuestion).HasColumnName("Id_Question");
            entity.Property(e => e.Categorie)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Enonce)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Numero)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Reponse>(entity =>
        {
            entity.HasKey(e => e.IdReponse).HasName("PK__Reponse__6DC7FE87EE061A5F");

            entity.ToTable("Reponse");

            entity.Property(e => e.IdReponse).HasColumnName("Id_Reponse");
            entity.Property(e => e.IdDonneur).HasColumnName("Id_Donneur");
            entity.Property(e => e.IdQuestion).HasColumnName("Id_Question");
            entity.Property(e => e.PrecisionPourMedecin).IsUnicode(false);
            entity.Property(e => e.Reponse1).HasColumnName("Reponse");

            entity.HasOne(d => d.IdDonneurNavigation).WithMany(p => p.Reponses)
                .HasForeignKey(d => d.IdDonneur)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Reponse__Id_Donn__286302EC");

            entity.HasOne(d => d.IdQuestionNavigation).WithMany(p => p.Reponses)
                .HasForeignKey(d => d.IdQuestion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Reponse__Id_Ques__29572725");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

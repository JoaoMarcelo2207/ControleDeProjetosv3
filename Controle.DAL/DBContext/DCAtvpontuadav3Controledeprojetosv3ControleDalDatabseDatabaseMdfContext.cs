using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Controle.MODEL;

public partial class DCAtvpontuadav3Controledeprojetosv3ControleDalDatabseDatabaseMdfContext : DbContext
{
    public DCAtvpontuadav3Controledeprojetosv3ControleDalDatabseDatabaseMdfContext()
    {
    }

    public DCAtvpontuadav3Controledeprojetosv3ControleDalDatabseDatabaseMdfContext(DbContextOptions<DCAtvpontuadav3Controledeprojetosv3ControleDalDatabseDatabaseMdfContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Projeto> Projetos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\C#\\atvPontuadaV3\\ControleDeProjetosv3\\Controle.DAL\\databse\\database.mdf;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Projeto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__projeto__3214EC07D0FF0898");

            entity.ToTable("projeto");

            entity.Property(e => e.DataF)
                .HasColumnType("date")
                .HasColumnName("data_f");
            entity.Property(e => e.DataI)
                .HasColumnType("date")
                .HasColumnName("data_i");
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.NomeGerente)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nome_gerente");
            entity.Property(e => e.Resumo)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("resumo");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

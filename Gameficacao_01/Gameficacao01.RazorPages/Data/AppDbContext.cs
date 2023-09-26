using Gameficacao01.RazorPages.Models;
using Gameficacao01.RazorPages.Models;
using Microsoft.EntityFrameworkCore;

namespace Gameficacao01.RazorPages.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<ConsultaModel> Consultas { get; set; }
        public DbSet<EspecialidadeModel> Especialidades { get; set; }
        public DbSet<MedicoModel> Medicos { get; set; }
        public DbSet<PacienteModel> Pacientes { get; set; }
        public DbSet<RecepcionistaModel> Recepcionistas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("DataSource=tds.db;Cache=Shared");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ConsultaModel>().ToTable("Consultas").HasKey(c => c.ConsultaId);
            modelBuilder.Entity<ConsultaModel>().Property(c => c.ConsultaId).ValueGeneratedOnAdd();
            modelBuilder.Entity<EspecialidadeModel>().ToTable("Especialidades").HasKey(e => e.EspecialidadeId);
            modelBuilder.Entity<EspecialidadeModel>().Property(e => e.EspecialidadeId).ValueGeneratedOnAdd();
            modelBuilder.Entity<MedicoModel>().ToTable("Medicos").HasKey(m => m.MedicoId);
            modelBuilder.Entity<MedicoModel>().Property(m => m.MedicoId).ValueGeneratedOnAdd();
            modelBuilder.Entity<PacienteModel>().ToTable("Pacientes").HasKey(p => p.PacienteId);
            modelBuilder.Entity<PacienteModel>().Property(p => p.PacienteId).ValueGeneratedOnAdd();
            modelBuilder.Entity<RecepcionistaModel>().ToTable("Recepcionistas").HasKey(r => r.RecepcionistaId);
            modelBuilder.Entity<RecepcionistaModel>().Property(r => r.RecepcionistaId).ValueGeneratedOnAdd();

            modelBuilder.Entity<MedicoModel>()
                .HasMany(m => m.Consultas)
                .WithMany()
                .UsingEntity<Dictionary<string, object>>(
                    "MedicoModel",
                    c => c.HasOne<ConsultaModel>().WithMany().HasForeignKey("ConsultaId"),
                    m => m.HasOne<MedicoModel>().WithMany().HasForeignKey("MedicoId"),
                    cm =>
                    {
                        cm.HasKey("ConsultaId", "MedicoId");
                        cm.ToTable("MedicoConsulta");
                    }
                );

            modelBuilder.Entity<EspecialidadeModel>()
                .HasMany(e => e.Medicos)
                .WithMany()
                .UsingEntity<Dictionary<string, object>>(
                    "EspecialidadeModel",
                    m => m.HasOne<MedicoModel>().WithMany().HasForeignKey("MedicoId"),
                    e => e.HasOne<EspecialidadeModel>().WithMany().HasForeignKey("EspecialidadeId"),
                    me =>
                    {
                        me.HasKey("MedicoId", "EspecialidadeId");
                        me.ToTable("EspecialidadeMedico");
                    }
                );

            modelBuilder.Entity<PacienteModel>()
                .HasMany(p => p.Consultas)
                .WithMany()
                .UsingEntity<Dictionary<string, object>>(
                    "PacienteModel",
                    c => c.HasOne<ConsultaModel>().WithMany().HasForeignKey("ConsultaId"),
                    p => p.HasOne<PacienteModel>().WithMany().HasForeignKey("PacienteId"),
                    cp =>
                    {
                        cp.HasKey("ConsultaId", "PacienteId");
                        cp.ToTable("PacienteConsulta");
                    }
                );

            modelBuilder.Entity<RecepcionistaModel>()
                .HasMany(r => r.Consultas)
                .WithMany()
                .UsingEntity<Dictionary<string, object>>(
                    "RecepcionistaModel",
                    c => c.HasOne<ConsultaModel>().WithMany().HasForeignKey("ConsultaId"),
                    r => r.HasOne<RecepcionistaModel>().WithMany().HasForeignKey("RecepcionistaId"),
                    cr =>
                    {
                        cr.HasKey("ConsultaId", "RecepcionistaId");
                        cr.ToTable("RecepcionistaConsulta");
                    }
                );
        }
    }
}
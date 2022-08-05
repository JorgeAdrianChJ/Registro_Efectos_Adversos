using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Registro_Efectos_Adversos.Models
{
    public partial class registro_efectos_adversosContext : DbContext
    {
        public registro_efectos_adversosContext()
        {
        }

        public registro_efectos_adversosContext(DbContextOptions<registro_efectos_adversosContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Clinica> Clinicas { get; set; } = null!;
        public virtual DbSet<Medico> Medicos { get; set; } = null!;
        public virtual DbSet<Paciente> Pacientes { get; set; } = null!;
        public virtual DbSet<Solicitud> Solicituds { get; set; } = null!;
        public virtual DbSet<Vacuna> Vacunas { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=registro_efectos_adversos;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clinica>(entity =>
            {
                entity.ToTable("clinica");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CedulaJurica)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cedula_jurica");

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.Distrito)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("distrito");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Pais)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pais");

                entity.Property(e => e.Provincia)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("provincia");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("telefono");

                entity.Property(e => e.Web)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("web");
            });

            modelBuilder.Entity<Medico>(entity =>
            {
                entity.ToTable("medico");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CodigoProfesional)
                    .HasMaxLength(50)
                    .HasColumnName("codigo_profesional");

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .HasColumnName("correo");

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .HasColumnName("estado");

                entity.Property(e => e.Identificacion)
                    .HasMaxLength(50)
                    .HasColumnName("identificacion");

                entity.Property(e => e.NombreCompleto)
                    .HasMaxLength(100)
                    .HasColumnName("nombre_completo");

                entity.Property(e => e.Pais)
                    .HasMaxLength(50)
                    .HasColumnName("pais");
            });

            modelBuilder.Entity<Paciente>(entity =>
            {
                entity.ToTable("paciente");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.Distrito)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("distrito");

                entity.Property(e => e.EstadoCivil)
                    .HasMaxLength(1)
                    .HasColumnName("estado_civil")
                    .IsFixedLength();

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnType("date")
                    .HasColumnName("fecha_nacimiento");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("date")
                    .HasColumnName("fecha_registro");

                entity.Property(e => e.Identificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("identificacion");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.NumeroContacto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("numero_contacto");

                entity.Property(e => e.Ocupacion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ocupacion");

                entity.Property(e => e.Pais)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pais");

                entity.Property(e => e.PrimerApellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("primer_apellido");

                entity.Property(e => e.Provincia)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("provincia");

                entity.Property(e => e.SegundoApellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("segundo_apellido");

                entity.Property(e => e.Sexo)
                    .HasMaxLength(1)
                    .HasColumnName("sexo")
                    .IsFixedLength();

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("telefono");
            });

            modelBuilder.Entity<Solicitud>(entity =>
            {
                entity.ToTable("solicitud");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdClinica).HasColumnName("id_clinica");

                entity.Property(e => e.IdMedico).HasColumnName("id_medico");

                entity.Property(e => e.IdPaciente).HasColumnName("id_paciente");

                entity.Property(e => e.IdVacuna).HasColumnName("id_vacuna");

                entity.Property(e => e.Respuesta1).HasColumnName("respuesta1");

                entity.Property(e => e.Respuesta10).HasColumnName("respuesta10");

                entity.Property(e => e.Respuesta11).HasColumnName("respuesta11");

                entity.Property(e => e.Respuesta12).HasColumnName("respuesta12");

                entity.Property(e => e.Respuesta13).HasColumnName("respuesta13");

                entity.Property(e => e.Respuesta14).HasColumnName("respuesta14");

                entity.Property(e => e.Respuesta15).HasColumnName("respuesta15");

                entity.Property(e => e.Respuesta16).HasColumnName("respuesta16");

                entity.Property(e => e.Respuesta17)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("respuesta17");

                entity.Property(e => e.Respuesta18).HasColumnName("respuesta18");

                entity.Property(e => e.Respuesta19).HasColumnName("respuesta19");

                entity.Property(e => e.Respuesta2).HasColumnName("respuesta2");

                entity.Property(e => e.Respuesta21).HasColumnName("respuesta21");

                entity.Property(e => e.Respuesta22).HasColumnName("respuesta22");

                entity.Property(e => e.Respuesta23).HasColumnName("respuesta23");

                entity.Property(e => e.Respuesta24).HasColumnName("respuesta24");

                entity.Property(e => e.Respuesta25).HasColumnName("respuesta25");

                entity.Property(e => e.Respuesta26).HasColumnName("respuesta26");

                entity.Property(e => e.Respuesta27).HasColumnName("respuesta27");

                entity.Property(e => e.Respuesta28).HasColumnName("respuesta28");

                entity.Property(e => e.Respuesta29).HasColumnName("respuesta29");

                entity.Property(e => e.Respuesta3).HasColumnName("respuesta3");

                entity.Property(e => e.Respuesta30).HasColumnName("respuesta30");

                entity.Property(e => e.Respuesta31).HasColumnName("respuesta31");

                entity.Property(e => e.Respuesta32).HasColumnName("respuesta32");

                entity.Property(e => e.Respuesta33).HasColumnName("respuesta33");

                entity.Property(e => e.Respuesta34).HasColumnName("respuesta34");

                entity.Property(e => e.Respuesta35).HasColumnName("respuesta35");

                entity.Property(e => e.Respuesta36).HasColumnName("respuesta36");

                entity.Property(e => e.Respuesta37).HasColumnName("respuesta37");

                entity.Property(e => e.Respuesta38).HasColumnName("respuesta38");

                entity.Property(e => e.Respuesta39).HasColumnName("respuesta39");

                entity.Property(e => e.Respuesta4).HasColumnName("respuesta4");

                entity.Property(e => e.Respuesta40).HasColumnName("respuesta40");

                entity.Property(e => e.Respuesta41).HasColumnName("respuesta41");

                entity.Property(e => e.Respuesta42).HasColumnName("respuesta42");

                entity.Property(e => e.Respuesta43).HasColumnName("respuesta43");

                entity.Property(e => e.Respuesta44).HasColumnName("respuesta44");

                entity.Property(e => e.Respuesta45).HasColumnName("respuesta45");

                entity.Property(e => e.Respuesta46).HasColumnName("respuesta46");

                entity.Property(e => e.Respuesta47).HasColumnName("respuesta47");

                entity.Property(e => e.Respuesta48).HasColumnName("respuesta48");

                entity.Property(e => e.Respuesta49).HasColumnName("respuesta49");

                entity.Property(e => e.Respuesta5).HasColumnName("respuesta5");

                entity.Property(e => e.Respuesta50).HasColumnName("respuesta50");

                entity.Property(e => e.Respuesta51).HasColumnName("respuesta51");

                entity.Property(e => e.Respuesta52).HasColumnName("respuesta52");

                entity.Property(e => e.Respuesta53).HasColumnName("respuesta53");

                entity.Property(e => e.Respuesta54).HasColumnName("respuesta54");

                entity.Property(e => e.Respuesta55).HasColumnName("respuesta55");

                entity.Property(e => e.Respuesta56).HasColumnName("respuesta56");

                entity.Property(e => e.Respuesta57).HasColumnName("respuesta57");

                entity.Property(e => e.Respuesta58).HasColumnName("respuesta58");

                entity.Property(e => e.Respuesta59).HasColumnName("respuesta59");

                entity.Property(e => e.Respuesta6).HasColumnName("respuesta6");

                entity.Property(e => e.Respuesta60).HasColumnName("respuesta60");

                entity.Property(e => e.Respuesta61).HasColumnName("respuesta61");

                entity.Property(e => e.Respuesta62).HasColumnName("respuesta62");

                entity.Property(e => e.Respuesta63).HasColumnName("respuesta63");

                entity.Property(e => e.Respuesta64).HasColumnName("respuesta64");

                entity.Property(e => e.Respuesta65)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("respuesta65");

                entity.Property(e => e.Respuesta66)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("respuesta66");

                entity.Property(e => e.Respuesta67).HasColumnName("respuesta67");

                entity.Property(e => e.Respuesta68).HasColumnName("respuesta68");

                entity.Property(e => e.Respuesta69).HasColumnName("respuesta69");

                entity.Property(e => e.Respuesta7).HasColumnName("respuesta7");

                entity.Property(e => e.Respuesta70).HasColumnName("respuesta70");

                entity.Property(e => e.Respuesta71).HasColumnName("respuesta71");

                entity.Property(e => e.Respuesta72).HasColumnName("respuesta72");

                entity.Property(e => e.Respuesta73).HasColumnName("respuesta73");

                entity.Property(e => e.Respuesta74).HasColumnName("respuesta74");

                entity.Property(e => e.Respuesta75).HasColumnName("respuesta75");

                entity.Property(e => e.Respuesta76).HasColumnName("respuesta76");

                entity.Property(e => e.Respuesta77).HasColumnName("respuesta77");

                entity.Property(e => e.Respuesta78).HasColumnName("respuesta78");

                entity.Property(e => e.Respuesta79).HasColumnName("respuesta79");

                entity.Property(e => e.Respuesta8).HasColumnName("respuesta8");

                entity.Property(e => e.Respuesta80).HasColumnName("respuesta80");

                entity.Property(e => e.Respuesta81).HasColumnName("respuesta81");

                entity.Property(e => e.Respuesta82).HasColumnName("respuesta82");

                entity.Property(e => e.Respuesta83).HasColumnName("respuesta83");

                entity.Property(e => e.Respuesta84).HasColumnName("respuesta84");

                entity.Property(e => e.Respuesta85).HasColumnName("respuesta85");

                entity.Property(e => e.Respuesta86).HasColumnName("respuesta86");

                entity.Property(e => e.Respuesta87).HasColumnName("respuesta87");

                entity.Property(e => e.Respuesta88).HasColumnName("respuesta88");

                entity.Property(e => e.Respuesta89).HasColumnName("respuesta89");

                entity.Property(e => e.Respuesta9).HasColumnName("respuesta9");

                entity.HasOne(d => d.IdClinicaNavigation)
                    .WithMany(p => p.Solicituds)
                    .HasForeignKey(d => d.IdClinica)
                    .HasConstraintName("FK_solicitud_clinica");

                entity.HasOne(d => d.IdMedicoNavigation)
                    .WithMany(p => p.Solicituds)
                    .HasForeignKey(d => d.IdMedico)
                    .HasConstraintName("FK_solicitud_medico");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.Solicituds)
                    .HasForeignKey(d => d.IdPaciente)
                    .HasConstraintName("FK_solicitud_paciente");

                entity.HasOne(d => d.IdVacunaNavigation)
                    .WithMany(p => p.Solicituds)
                    .HasForeignKey(d => d.IdVacuna)
                    .HasConstraintName("FK_solicitud_vacuna");
            });

            modelBuilder.Entity<Vacuna>(entity =>
            {
                entity.ToTable("vacuna");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FechaAplicacion)
                    .HasColumnType("date")
                    .HasColumnName("fecha_aplicacion");

                entity.Property(e => e.FechaVencimiento)
                    .HasColumnType("date")
                    .HasColumnName("fecha_vencimiento");

                entity.Property(e => e.Lote).HasColumnName("lote");

                entity.Property(e => e.LugarAplicacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lugar_aplicacion");

                entity.Property(e => e.Marca)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("marca");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("observaciones");

                entity.Property(e => e.Respuesta1).HasColumnName("respuesta1");

                entity.Property(e => e.Respuesta2).HasColumnName("respuesta2");

                entity.Property(e => e.Respuesta3).HasColumnName("respuesta3");

                entity.Property(e => e.Respuesta4)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("respuesta4");

                entity.Property(e => e.Respuesta5).HasColumnName("respuesta5");

                entity.Property(e => e.Respuesta6).HasColumnName("respuesta6");

                entity.Property(e => e.Respuesta7)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("respuesta7");

                entity.Property(e => e.Respuesta8)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("respuesta8");

                entity.Property(e => e.Respuesta9)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("respuesta9");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

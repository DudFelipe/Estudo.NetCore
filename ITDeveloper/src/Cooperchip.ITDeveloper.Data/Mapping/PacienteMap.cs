using Cooperchip.ITDeveloper.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cooperchip.ITDeveloper.Data.Mapping
{
    public class PacienteMap : IEntityTypeConfiguration<Paciente>
    {
        public void Configure(EntityTypeBuilder<Paciente> builder)
        {
            builder.HasKey(n => n.Id);
            builder.Property(p => p.Nome).IsRequired().HasColumnType("varchar(80)")
                .HasColumnName("Nome");

            builder.Property(e => e.Email).HasColumnName("Email")
                .HasColumnType("varchar(150)");

            builder.Property(c => c.Cpf)
                .HasMaxLength(11).IsFixedLength(true) //Definindo o tamanho máximo e que é tamanho fixo
                .HasColumnName("Cpf").HasColumnType("varchar(11)");

            builder.Property(r => r.Rg).HasMaxLength(15).HasColumnName("Rg")
                .HasColumnType("varchar(15)");

            builder.Property(o => o.RgOrgao).HasColumnName("RgOrgao")
                .HasColumnType("varchar(10)");

            // 1:1 => Paciente : EstadoPaciente OU 0:N => EstadoPaciente : Paciente
            builder.HasOne(ep => ep.EstadoPaciente) //O paciente tem um EstadoPaciente
                .WithMany(pc => pc.Paciente) //O EstadoPaciente tem muitos Pacientes
                .HasForeignKey(p => p.EstadoPacienteId) //A chave estrangeira
                .HasPrincipalKey(p => p.Id); //Chave principal de Paciente

            builder.ToTable("Paciente"); //Mapeando a tabela
        }
    }
}

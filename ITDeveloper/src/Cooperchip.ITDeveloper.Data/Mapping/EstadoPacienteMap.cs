using Cooperchip.ITDeveloper.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cooperchip.ITDeveloper.Data.Mapping
{
    public class EstadoPacienteMap : IEntityTypeConfiguration<EstadoPaciente>
    {
        public void Configure(EntityTypeBuilder<EstadoPaciente> builder)
        {
            //Usando Fluent API

            builder.HasKey(pk => pk.Id); //Mapeando o ID da entidade

            //Mapeando o campo Descricao
            builder.Property(p => p.Descricao).HasColumnType("varchar(30)")
                .HasColumnName("Descricao"); //Nome da coluna no banco

            builder.HasMany(p => p.Paciente);

            builder.ToTable("EstadoPaciente"); //Mapeando a tabela
        }
    }
}

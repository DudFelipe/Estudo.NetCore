using Cooperchip.ITDeveloper.Domain.Entities;
using Cooperchip.ITDeveloper.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Cooperchip.ITDeveloper.Domain.Models
{
    public class Paciente : EntityBase
    {
        public Paciente()
        {
            this.Ativo = true;
        }

        //Criando o relacionamento com a classe EstadoPaciente 1:1, todo paciente tem um estado de paciente
        [ForeignKey("EstadoPaciente")]
        [Display(Name = "Estado do Paciente")]
        public Guid EstadoPacienteId { get; set; }
        public virtual EstadoPaciente EstadoPaciente { get; set; }

        [DisplayName(displayName: "Nome do Paciente")]
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataInternacao { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
        public string Cpf { get; set; }
        public TipoPaciente TipoPaciente { get; set; }
        public Sexo Sexo { get; set; }
        public string Rg { get; set; }
        public string RgOrgao{ get; set; }
        public DateTime RgDataEmissao { get; set; }

        public override string ToString()
        {
            return this.Id.ToString() + " - " + this.Nome;
        }
    }
}

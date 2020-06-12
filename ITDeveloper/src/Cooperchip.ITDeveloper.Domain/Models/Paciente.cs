using Cooperchip.ITDeveloper.Domain.Entities;
using Cooperchip.ITDeveloper.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cooperchip.ITDeveloper.Domain.Models
{
    public class Paciente : EntityBase
    {
        public Paciente()
        {
            this.DataInternacao = DateTime.Now;
            this.Ativo = true;
        }

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

using Cooperchip.ITDeveloper.Domain.Enums;

namespace ConsoleApp
{
    class Paciente
    {
        public Paciente(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        public string Nome { get; private set; }
        public int Idade { get; private set; }

        public TipoMovimentoPaciente TipoMovimentoPaciente { get; set; }
        public TipoEntradaPaciente TipoEntradaPaciente { get; set; }
        public TipoSaidaPaciente TipoSaidaPaciente { get; set; }
    }
}

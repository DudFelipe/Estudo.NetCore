using System;
using System.Collections.Generic;
using System.Text;

namespace Cooperchip.ITDeveloper.Domain.Entities
{
    public class Produto
    {
        public Produto()
        {
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; } = 0;
        public int Estoque { get; set; }
        public DateTime Validade { get; set; }
        public bool TemEmEstoque { get; set; } = true;
    }
}

using Cooperchip.ITDeveloper.Domain.Entities;
using System.Collections.Generic;

namespace Cooperchip.ITDeveloper.Mvc.ViewModels
{
    public class CarrinhoViewModel
    {
        public IList<Produto> Produtos { get; set; }
        public decimal TotalCarrinho { get; set; }
        public string Mensagem { get; set; }
    }
}

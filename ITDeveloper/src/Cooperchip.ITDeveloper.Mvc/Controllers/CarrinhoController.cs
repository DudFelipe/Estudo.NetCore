using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cooperchip.ITDeveloper.Domain.Entities;
using Cooperchip.ITDeveloper.Mvc.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Cooperchip.ITDeveloper.Mvc.Controllers
{
    public class CarrinhoController : Controller
    {
        public IActionResult Index()
        {
            var produtos = new List<Produto>();

            for(int i = 1; i < 11; i++)
            {
                var n = i < 10 ? "0" + i : i + "";
                produtos.Add(new Produto
                {
                    Nome = "Prod-" + n,
                    Estoque = 3,
                    Validade = DateTime.Now,
                    Valor = 1.13M * i,
                });
            }

            var model = new CarrinhoViewModel
            {
                Produtos = produtos,
                TotalCarrinho = produtos.Sum(p => p.Valor),
                Mensagem = "Obrigado por comprar conosco!"
            };

            return View(model);
        }
    }
}

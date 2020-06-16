﻿using Cooperchip.ITDeveloper.Data.ORM;
using Cooperchip.ITDeveloper.Mvc.ViewComponents.Helpers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cooperchip.ITDeveloper.Mvc.ViewComponents.EstadoPaciente
{
    [ViewComponent(Name = "EstadoEstavel")]
    public class EstadoEstavelViewComponents : ViewComponent
    {
        private readonly ITDeveloperDbContext _context;

        public EstadoEstavelViewComponents(ITDeveloperDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var totalGeral = Util.TotReg(_context);
            decimal totalEstado = Util.GetNumRegEstado(_context, "Estável");

            decimal progress = totalEstado * 100 / totalGeral;
            var prct = progress.ToString("F1");

            var model = new ContadorEstadoPaciente()
            {
                Titulo = "Estado Estável",
                Parcial = (int)totalEstado,
                Percentual = prct,
                ClassContainer = "panel panel-success tile panelClose panelRefresh",
                IconeLg = "l-ecommerce-cart-content",
                IconeSm = "fa fa-arrow-circle-o-up s20 mr5 pull-left",
                Progress = progress
            };

            return View(model);
        }
    }
}

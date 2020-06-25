using Cooperchip.ITDeveloper.Data.ORM;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cooperchip.ITDeveloper.Mvc.Extentions.ViewComponents.Helpers
{
    public static class Util
    {
        public static int TotReg(ITDeveloperDbContext ctx)
        {
            return (from pac in ctx.Paciente.AsNoTracking() select pac).Count();
        }

        public static decimal GetNumRegEstado(ITDeveloperDbContext ctx, string estado)
        {
            return ctx.Paciente.AsNoTracking().Count(x => x.EstadoPaciente.Descricao.Contains(estado));
        }
    }
}

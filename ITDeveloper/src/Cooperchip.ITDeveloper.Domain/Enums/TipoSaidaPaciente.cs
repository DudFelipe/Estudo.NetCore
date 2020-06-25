using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Cooperchip.ITDeveloper.Domain.Enums
{
    public enum TipoSaidaPaciente
    {
        [Description("Recebeu Alta")] Alta = 1,
        [Description("Transferido")] Transferencia,
        [Description("Saiu à Revelia")] ARevelia,
        [Description("Veio a Óbito")] Obito,
        Outros  
    }
}

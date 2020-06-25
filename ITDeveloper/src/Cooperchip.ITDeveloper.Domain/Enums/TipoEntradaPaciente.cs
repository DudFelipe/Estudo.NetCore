using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Cooperchip.ITDeveloper.Domain.Enums
{
    public enum TipoEntradaPaciente
    {
        [Description("Internação")] Internacao = 1,
        [Description("Emergência")] Emergencia,
        [Description("Transferência")] Transferencia,
        [Description("Ambulatório")] Ambulatorio,
        [Description("Sem Prontuário")] SemProntuario
    }
}

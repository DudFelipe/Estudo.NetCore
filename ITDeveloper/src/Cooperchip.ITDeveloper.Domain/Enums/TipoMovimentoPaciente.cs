﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Cooperchip.ITDeveloper.Domain.Enums
{
    public enum TipoMovimentoPaciente
    {
        [Description("Entrada de Paciente")] Entrada = 1,
        [Description("Saída de Paciente")] Saida
    }
}

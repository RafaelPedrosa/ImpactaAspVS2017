﻿using System.ComponentModel;

namespace Oficina.Dominio
{
    public enum Cambio
    {
        [Description("Automático")]
        Automatico = 1,
        Manual = 2,
        [Description("Semi Automático")]
        Semi_Automatico = 3
    }
}
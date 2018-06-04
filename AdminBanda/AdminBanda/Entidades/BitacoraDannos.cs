using System;
using System.Collections.Generic;
using System.Text;

namespace AdminBanda.Entidades
{
    public class BitacoraDannos
    {
        string CodigoInstrumento { set; get; }
        string FechaRegistro { set; get; }
        string descripcionDanno { set; get; }
        bool Reparado { set; get; }
        string DescripcionReparacion { set; get; }
        string FechaReparacion { set; get; }
    }
}

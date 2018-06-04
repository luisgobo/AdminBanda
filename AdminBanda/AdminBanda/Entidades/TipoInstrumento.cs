using System;
using System.Collections.Generic;
using System.Text;

namespace AdminBanda.Entidades
{
    public class TipoInstrumento
    {
        string Codigo { set; get; }
        string Descripcion { set; get; }
        TipoInstrumento Seccion { set; get; }
        bool estado { set; get; }
    }
}

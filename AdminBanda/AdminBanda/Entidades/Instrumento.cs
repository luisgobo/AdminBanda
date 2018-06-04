using System;
using System.Collections.Generic;
using System.Text;

namespace AdminBanda.Entidades
{
    public class Instrumento
    {
        string Codigo { set; get; }
        TipoInstrumento TipoInstruento { set; get; }
        int Propiedad { set; get; }
        int Estado { set; get; }        
    }
}

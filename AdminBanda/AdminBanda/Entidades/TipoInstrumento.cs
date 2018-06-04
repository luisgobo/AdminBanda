using System;
using System.Collections.Generic;
using System.Text;

namespace AdminBanda.Entidades
{
    public class TipoInstrumento
    {
        public string Codigo { set; get; }
        public string Descripcion { set; get; }
        public SeccionInstrumento Seccion { set; get; }
        public bool estado { set; get; }
    }
}

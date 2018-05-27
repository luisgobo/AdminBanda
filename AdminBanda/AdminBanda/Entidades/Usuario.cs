using System;
using System.Collections.Generic;
using System.Text;

namespace AdminBanda.Entidades
{
    public class Usuario
    {
        public string NombreUsuario { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Nombre { get; set; }

        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public int Id { get; set; }
    }
}

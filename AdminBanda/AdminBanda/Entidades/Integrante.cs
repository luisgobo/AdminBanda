using SQLite;
using System;

namespace AdminBanda.Entidades
{
    public class Integrante
    {
        [PrimaryKey, AutoIncrement]
        public int CodigoIntegrante { get; set; }

        public string Identificacion { get; set; }
        public string TipoIdentificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool Activo { get; set; }
        public string NombreCompleto { get { return Nombre + " " + Apellido1 + " " + Apellido2; } }
    }
}
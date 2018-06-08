using SQLite;

namespace AdminBanda.Entidades
{
    public class Instrumento
    {
        public Instrumento() { }

        [PrimaryKey, AutoIncrement]
        public int Codigo { set; get; }
        public string DescripcionInstrumento { get; set; }
        public int TipoInstruento { set; get; }        
        public int Propiedad { set; get; }
        public int Estado { set; get; }

    }
}
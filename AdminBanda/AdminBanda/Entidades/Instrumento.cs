using SQLite;

namespace AdminBanda.Entidades
{
    public class Instrumento
    {
        public Instrumento() { }

        [PrimaryKey, AutoIncrement]
        public string Codigo { set; get; }
        public int TipoInstruento { set; get; }
        public int Propiedad { set; get; }
        public int Estado { set; get; }

        //string descripcionInstrumento { get { return TipoInstruento.Descripcion; } }
    }
}
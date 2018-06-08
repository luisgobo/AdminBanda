using AdminBanda.Datos;
using AdminBanda.Entidades;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AdminBanda.Instrumentos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListadoInstrumentos
    {
        public ListadoInstrumentos()
        {
            RefrescarCommand = new Command(obj => Refrescar());

            InitializeComponent();

            BindingContext = this;

            //Cargar Datos
            GetInstrumentos();

            listadoInstrumentos.ItemSelected += delegate
            {
                var elementoSeleccionado = listadoInstrumentos.SelectedItem as Instrumento;
                //var contenedor = this.Parent.Parent as TabbedPage;
                var masterPage = this.Parent.Parent as TabbedPage;
                masterPage.CurrentPage = masterPage.Children[1];
                masterPage.BindingContext = elementoSeleccionado;
            };
        }

        public void GetInstrumentos()
        {
            listadoInstrumentos.ItemsSource = new ObservableCollection<Instrumento>(App.Database.GetInstrumentos());
        }

        public Command RefrescarCommand { get; set; }

        private async void Refrescar()
        {
            //IsBusy
            listadoInstrumentos.ItemsSource = null;

            await Task.Delay(2 * 1000);
            GetInstrumentos();
        }

        private void Agregar()
        {
            //Datos.Add(new Usuario { Nombre = "valor nuevo" });
        }
    }
}
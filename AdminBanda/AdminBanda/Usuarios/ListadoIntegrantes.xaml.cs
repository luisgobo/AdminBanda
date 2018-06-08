using AdminBanda.Entidades;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AdminBanda.Usuarios
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListadoIntegrantes
    {
        public ListadoIntegrantes()
        {
            RefrescarCommand = new Command(obj => Refrescar());

            InitializeComponent();

            BindingContext = this;

            //Cargar Datos
            GetIntegrantes();

            listadoIntegrantes.ItemSelected += delegate
            {
                var elementoSeleccionado = listadoIntegrantes.SelectedItem as Integrante;
                //var contenedor = this.Parent.Parent as TabbedPage;
                var masterPage = this.Parent.Parent as TabbedPage;
                masterPage.CurrentPage = masterPage.Children[1];
                masterPage.BindingContext = elementoSeleccionado;
            };
        }

        public void GetIntegrantes()
        {            
            listadoIntegrantes.ItemsSource = new ObservableCollection<Integrante>(App.Database.GetIntegrantes());
        }

        public Command RefrescarCommand { get; set; }

        private async void Refrescar()
        {
            //IsBusy
            listadoIntegrantes.ItemsSource = null;

            await Task.Delay(2 * 1000);
            GetIntegrantes();
        }

        private void Agregar()
        {
            //Datos.Add(new Usuario { Nombre = "valor nuevo" });
        }
    }
}
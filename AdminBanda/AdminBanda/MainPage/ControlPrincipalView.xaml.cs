using AdminBanda.Entidades;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AdminBanda.MainPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ControlPrincipalView
    {
        public ObservableCollection<Usuario> Datos { get; set; }
        public Command RefrescarCommand { get; set; }

        public ControlPrincipalView()
        {
            RefrescarCommand = new Command(obj => Refrescar());

            InitializeComponent();

            BindingContext = this;

            Datos = new ObservableCollection<Usuario> {
                new Usuario { NombreUsuario = "prueba 1"},
                new Usuario { NombreUsuario = "prueba 2"},
                new Usuario { NombreUsuario = "prueba 3"}
            };

            botonAgregar.Command = new Command(obj => Agregar());

            listadoDatos.ItemsSource = Datos;
            listadoDatos.ItemSelected += delegate
            {
                var seleccionado = listadoDatos.SelectedItem as Usuario;

                App.Current.MainPage.DisplayAlert("Seleccionado:", $"{seleccionado.NombreUsuario}", "Cerrar");
            };
        }

        private async void Refrescar()
        {
            //IsBusy
            Datos.Clear();

            await Task.Delay(2 * 1000);

            Datos.Add(new Usuario { Nombre = "prueba 1" });
            Datos.Add(new Usuario { Nombre = "prueba 2" });
            Datos.Add(new Usuario { Nombre = "prueba 3" });

            //Task.WaitAll
            //Task.WaitAny

            listadoDatos.IsRefreshing = false;
        }

        private void Agregar()
        {
            Datos.Add(new Usuario { Nombre = "valor nuevo" });
        }
    }
}
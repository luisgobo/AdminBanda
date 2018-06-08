using AdminBanda.Datos;
using AdminBanda.Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AdminBanda.Instrumentos
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListadoInstrumentos
	{
		public ListadoInstrumentos ()
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
            ObservableCollection<Instrumento> rawData = GetData.obtenerInstrumentos();
            listadoInstrumentos.ItemsSource = rawData;
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
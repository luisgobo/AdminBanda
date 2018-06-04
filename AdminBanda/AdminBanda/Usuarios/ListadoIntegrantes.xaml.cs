using AdminBanda.Datos;
using AdminBanda.Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
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
            ObservableCollection<Integrante> rawData =  GetData.obtenerIntegrantes();            
            listadoIntegrantes.ItemsSource = rawData;
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
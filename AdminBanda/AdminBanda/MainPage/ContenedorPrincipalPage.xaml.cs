using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AdminBanda.MainPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContenedorPrincipalPage
    {
        public ContenedorPrincipalPage()
        {
            InitializeComponent();

            var paginaMenu = new MenuPage();

            paginaMenu.Title = "Opciones";
            paginaMenu.Menu.Add(new Entidades.MenuItem()
            {
                Icon = "",
                Title = "Clase 1",
                Command = new Command(() => Navegar(new ContentPage { Content = new Label { Text = "Welcome to Xamarin.Forms!" } }))
            });

            //Agregar Menu al maestro detalle
            Master = paginaMenu;

        }

        private void Navegar(Page page)
        {
            Detail = page;

            IsPresented = false;
        }
    }
}
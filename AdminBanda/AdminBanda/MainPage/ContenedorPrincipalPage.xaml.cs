using AdminBanda.Entidades;
using AdminBanda.Evento;
using AdminBanda.Instrumentos;
using AdminBanda.Usuarios;
using System;
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
            paginaMenu.Menu.Add(new Entidades.ContentMenuItem()
            {
                Icon = "ic_Principal.png",
                Title = "Inicio",
                Command = new Command(() => Navegar(new ContenedorPrincipalPage()))
            });

            paginaMenu.Menu.Add(new ContentMenuItem()
            {
                Icon = "ic_Integrante.png",
                Title = "Integrantes",                
                Command = new Command(() => Navegar(new DetalleEdicionIntegrante()))
            });

            paginaMenu.Menu.Add(new ContentMenuItem()
            {
                Icon = "ic_NotaMusical.png",
                Title = "Instrumentos",                
                Command = new Command(() => Navegar(new DetalleEdicionIntrumento()))
            });            

            //paginaMenu.Menu.Add(new ContentMenuItem()
            //{
            //    Icon = "",
            //    Title = "Eventos",
            //    Command = new Command(() => Navegar(new ContenedorEventoPage()))
            //});

            //paginaMenu.Menu.Add(new ContentMenuItem()
            //{
            //    Icon = "",
            //    Title = "Asistencia",
            //    Command = new Command(() => Navegar(new ContenedorAsistenciaPage()))
            //});

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
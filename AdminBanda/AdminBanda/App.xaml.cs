using AdminBanda.Datos;
using AdminBanda.MainPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AdminBanda
{
    public partial class App : Application
    {
        static SqlHelper database;
        public App()
        {
            InitializeComponent();

            //MainPage = new AdminBanda.MainPage();
            var mainPage = new ContenedorPrincipalPage()
            {
                Title = "Banda Movil",
            };

            NavigationPage nav = new NavigationPage(mainPage);
            nav.BarBackgroundColor = Color.Black;

            MainPage = nav;
        }

        public static SqlHelper Database
        {
            get
            {
                if (database == null)
                {
                    database = new SqlHelper();
                }
                return database;
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

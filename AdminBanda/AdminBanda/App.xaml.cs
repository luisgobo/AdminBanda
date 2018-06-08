﻿using AdminBanda.MainPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AdminBanda
{
    public partial class App : Application
    {
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

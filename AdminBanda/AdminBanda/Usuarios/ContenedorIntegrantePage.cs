﻿using AdminBanda.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AdminBanda.Usuarios
{
    public class ContenedorIntegrantePage : ContentPage
    {

        public ContenedorIntegrantePage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Integrantes" }
                }
            };
        }


        //      protected ControlPrincipalView ControlPrincipal { get; set; }

        //      public ContenedorUsuarioPage ()
        //{
        //          Title = "Listado de datos";

        //          ControlPrincipal = new ControlPrincipalView();
        //          Content = ControlPrincipal;

        //          base.ToolbarItems.Add(new ToolbarItem
        //          {
        //              Text = "Refrescar",
        //              Order = ToolbarItemOrder.Secondary,
        //              Command = ControlPrincipal.RefrescarCommand
        //          });
        //      }
    }
}
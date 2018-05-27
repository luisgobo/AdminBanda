using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AdminBanda.MainPage
{
    public class ContenedorPage : ContentPage
    {
        protected ControlPrincipalView ControlPrincipal { get; set; }

        public ContenedorPage()
        {
            Title = "Listado de datos";

            ControlPrincipal = new ControlPrincipalView();
            Content = ControlPrincipal;

            base.ToolbarItems.Add(new ToolbarItem
            {
                Text = "Refrescar",
                Order = ToolbarItemOrder.Secondary,
                Command = ControlPrincipal.RefrescarCommand
            });
        }
    }
}
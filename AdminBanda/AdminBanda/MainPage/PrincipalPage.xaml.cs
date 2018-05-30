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
	public partial class PrincipalPage : ContentPage
	{
		public PrincipalPage()
		{
			InitializeComponent ();

            //Boton1.Clicked += async (sender, args) =>
            //{
            //    await DisplayAlert("Saludos", "Hola Xamarin.Forms!", "Cerrar");

            //    LabelSalida.Text = $"Fecha:{DatePickerFechaNacimiento.Date}";

            //};
            //boton2.Clicked += MostrarPantalla;

        }

        private async void MostrarPantalla(object sender, EventArgs e)
        {
            ////await Navigation.PushModalAsync(new MainPage());
            //await Navigation.PushAsync(new ContenedorPage());
        }
    }
}
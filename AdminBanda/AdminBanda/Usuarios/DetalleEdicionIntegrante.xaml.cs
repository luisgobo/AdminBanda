using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AdminBanda.Usuarios
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalleEdicionIntegrante
    {

        public DetalleEdicionIntegrante()
        {
            InitializeComponent();
        }

        async void OnNavigateButtonClicked(object sender, EventArgs e)
        {
            //this.CurrentPage = this.Children[0];            
            //await Navigation.PopAsync();
            ////await Navigation.PopAsync(new ContenedorInstrumentoPage());
        }
    }
}
using AdminBanda.Instrumentos;
using System;
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

        private void OnNavigateButtonClicked(object sender, EventArgs e)
        {
            this.CurrentPage = this.Children[0];
        }

        private void OnCheckIntruments(object sender, EventArgs e)
        {
            
        }       
    }
}
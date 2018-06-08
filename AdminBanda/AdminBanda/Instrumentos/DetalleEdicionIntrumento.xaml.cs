using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AdminBanda.Instrumentos
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetalleEdicionIntrumento
	{
		public DetalleEdicionIntrumento ()
		{
			InitializeComponent ();
		}

        void OnNavigateButtonClicked(object sender, EventArgs e)
        {
            this.CurrentPage = this.Children[0];
        }

        void OnCheckIntruments(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGaleria.XamarinForms.PaginaMenuLateral
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PaginaMainMenu : FlyoutPage
    {
		public PaginaMainMenu ()
		{
			InitializeComponent ();
		}

        //private void Pagina01(object sender, EventArgs e)
        //{
        //    Navigation.PushAsync(new Pagina01());
        //}

        //private void Pagina02(object sender, EventArgs e)
        //{
        //    Navigation.PushAsync(new Pagina02());
        //}

        //private void Pagina03(object sender, EventArgs e)
        //{
        //    Navigation.PushAsync(new Pagina03());
        //}

    }
}
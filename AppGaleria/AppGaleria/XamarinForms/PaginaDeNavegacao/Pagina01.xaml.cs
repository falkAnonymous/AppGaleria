using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGaleria.XamarinForms.PaginaDeNavegacao
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina01 : ContentPage
    {
        public Pagina01()
        {
            InitializeComponent();
        }

        private void AvancarPaginas(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pagina02()); 
        }

    }
}
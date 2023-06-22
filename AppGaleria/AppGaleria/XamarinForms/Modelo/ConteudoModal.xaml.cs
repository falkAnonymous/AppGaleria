using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGaleria.XamarinForms.Modelo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConteudoModal : ContentPage
    {
        public ConteudoModal()
        {
            InitializeComponent();
        }

        private void PaginaModal(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new PaginaModal());// Abre a Janela
        }
    }
}
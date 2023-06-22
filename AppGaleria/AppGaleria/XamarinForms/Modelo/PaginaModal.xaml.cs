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
    public partial class PaginaModal : ContentPage
    {
        public PaginaModal()
        {
            InitializeComponent();
        }

        private void FecharModal(object sender, EventArgs e)
        {
            Navigation.PopModalAsync(); // Fecha a janela
        }
    }
}
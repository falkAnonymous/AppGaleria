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
    public partial class Pagina02 : ContentPage
    {
        public Pagina02()
        {
            InitializeComponent();
        }

        private void AvancarPagina03(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pagina03());
        }

        private void Button_Clicked(object sender, EventArgs e) // BTN Voltar
        {
            Navigation.PopAsync(); // Remove a janela anterior
        }
        protected override bool OnBackButtonPressed() // Essa função inpede de que possam utilizar o botão voltar do proprio celuar
        {
            return true;// True bloqueia , false ou nada função liberada
        }
    }
}
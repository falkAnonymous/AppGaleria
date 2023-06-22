using AppGaleria.XamarinForms.Paginas.Container;
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
    public partial class Pagina03 : ContentPage
    {
        public Pagina03()
        {
            InitializeComponent();
        }
        protected override bool OnBackButtonPressed()// Essa função inpede de que possam utilizar o botão voltar do proprio celuar
        {
            return true; // True bloqueia , false ou nada função liberada
        }

        private void Voltar(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void BTN_Inicio(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }

        private void Remover_Pagina(object sender, EventArgs e)
        {
            Navigation.RemovePage(Navigation.NavigationStack[2]);
        }

        private void Adicionar_Pagina(object sender, EventArgs e)
        {
            Navigation.InsertPageBefore(new Conteudo01xaml(), this);
        }

        private void Btn_PaginalInicial(object sender, EventArgs e) // Voltar ao iniciar sem deixar rastro
        {
            App.Current.MainPage = new NavigationPage(new Pagina01());
        }
    }
}
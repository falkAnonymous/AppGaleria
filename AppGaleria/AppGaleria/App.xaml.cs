using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppGaleria.XamarinForms.PaginaDeNavegacao;
using AppGaleria.XamarinForms.Modelo;
using AppGaleria.XamarinForms.PaginaCarrossel;
using AppGaleria.XamarinForms.CarrosselPaginas;
using AppGaleria.XamarinForms.PaginaComAbas;
using AppGaleria.XamarinForms.PaginaMenuLateral;

namespace AppGaleria
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //object pagina = new NavigationPage(new Pagina01());
            //MainPage = (Page)pagina;

            //object Modal = new ConteudoModal();
            //MainPage = (Page)Modal;

            //var Pagina = new CarouselPage();// Instancia um carrossel
            //Pagina.Children.Add(new PgCarrossel01());//Adiciona as paginas
            //Pagina.Children.Add(new PgCarrossel02());//Adiciona as paginas
            //Pagina.Children.Add(new PgCarrossel03());//Adiciona as paginas

            //Pagina.CurrentPage = Pagina.Children[1]; // Serve para escolher qual vai ser a pagina principal

            object Carrossel = new Carousel01();
            MainPage = (Page)Carrossel;

            //object PgAbas = new Pg_MainAbas();
            //MainPage = (Page)PgAbas;

            //object PgMenuLateral = new PaginaMainMenu();
            //MainPage = (Page)PgMenuLateral;

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

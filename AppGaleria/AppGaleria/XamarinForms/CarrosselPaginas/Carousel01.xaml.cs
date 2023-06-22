using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGaleria.XamarinForms.CarrosselPaginas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Carousel01 : CarouselPage
	{
		public Carousel01 ()
		{
			InitializeComponent ();

			CurrentPage = Children[1];
		}
	}
}
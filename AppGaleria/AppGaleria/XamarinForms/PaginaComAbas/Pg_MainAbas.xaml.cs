using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGaleria.XamarinForms.PaginaComAbas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Pg_MainAbas : TabbedPage
	{
		public Pg_MainAbas ()
		{
			InitializeComponent ();
			CurrentPage = Children[1];
		}
	}
}
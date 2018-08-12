using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_Xamarin.Master
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Master : MasterDetailPage
	{
		public Master ()
		{
			InitializeComponent ();
		}

        private void GoPaginaXamarin(object sender, EventArgs e)
        {
            Detail = new Pages.Xamarin();
        }

        private void GoPaginaPerfil1(object sender, EventArgs e)
        {
            Detail = new Pages.Perfil1();
        }
    }
}
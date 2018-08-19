using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_ControleXF.Controles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WebViewPage : ContentPage
	{
		public WebViewPage ()
		{
			InitializeComponent ();
		}

        private void GoPage(object sender, EventArgs e)
        {
            navegador.Source = EndSite.Text;
        }

        private void GoProximo(object sender, EventArgs e)
        {
            if (navegador.CanGoForward)
            {
                navegador.GoForward();
            }
        }

        private void GoVoltar(object sender, EventArgs e)
        {
            if (navegador.CanGoBack)
            {
                navegador.GoBack();
            }
        }

        private void ActionCarregando(object sender, WebNavigatingEventArgs e)
        {
            Lblstatus.Text = "Carregando..";
        }

        private void ActionCarregado(object sender, WebNavigatedEventArgs e)
        {
            Lblstatus.Text = "Finalizado.";
        }
    }
}
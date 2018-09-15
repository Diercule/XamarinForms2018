using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_Cell.Menu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Master : MasterDetailPage
	{
		public Master ()
		{
			InitializeComponent ();
		}

        private void TextCellPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Paginas.TextCellPage());
            IsPresented = false;
        }

        private void ImageCellPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Paginas.ImageCellPage());
            IsPresented = false;
        }

        private void EntryCellPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Paginas.EntryCellPage());
            IsPresented = false;
        }

        private void SwitchCellPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Paginas.SwitchCellPage());
            IsPresented = false;
        }

        private void ViewCellPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Paginas.ViewCellPage());
            IsPresented = false;
        }

        private void ListViewCellPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Paginas.ListViewPage());
            IsPresented = false;
        }

        private void ListViewButtonCellPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Paginas.ListViewButtonPage());
            IsPresented = false;
        }
    }
}
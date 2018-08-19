using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_ControleXF.Menu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Master : MasterDetailPage
	{
		public Master ()
		{
			InitializeComponent ();
		}

        private void GoActivityIndicatorPage(object sender, EventArgs e)
        {
            Detail = new Controles.ActivityIndicatorPage();
            IsPresented = false;
        }

        private void GoToProgressBarPage(object sender, EventArgs e)
        {
            Detail = new Controles.ProgressBarPage();
        }

        private void GoBoxViewPage(object sender, EventArgs e)
        {
            Detail = new Controles.BoxviewPage();
        }

        private void GoLabelPage(object sender, EventArgs e)
        {
            Detail = new Controles.LabelPage();
        }

        private void GoButtonPage(object sender, EventArgs e)
        {
            Detail = new Controles.ButtonPage();
        }

        private void GoEntryEditorPage(object sender, EventArgs e)
        {
            Detail = new Controles.EntryEditorPage();
        }

        private void GoDatePikerPage(object sender, EventArgs e)
        {
            Detail = new Controles.DatePikerPage();
        }

        private void GoTimerPikerPage(object sender, EventArgs e)
        {
            Detail = new Controles.TimePikerPage();
        }

        private void GoPikerPage(object sender, EventArgs e)
        {
            Detail = new Controles.PikerPage();
        }

        private void GoSearchBarPage(object sender, EventArgs e)
        {
            Detail = new Controles.SearchBarPage();
        }

        private void GoSliderStepperPage(object sender, EventArgs e)
        {
            Detail = new Controles.SliderStepperPage();
        }

        private void GoSwitchPage(object sender, EventArgs e)
        {
            Detail = new Controles.SwitchPage();
        }

        private void GoImagePage(object sender, EventArgs e)
        {
            Detail = new Controles.ImagePage();
        }

        private void GoListViewPage(object sender, EventArgs e)
        {
            Detail = new Controles.ListViewPage();
        }

        private void GotableViewPage(object sender, EventArgs e)
        {
            Detail = new Controles.TableViewPage();
        }

        private void GotoWebViewPage(object sender, EventArgs e)
        {
            Detail = new Controles.WebViewPage();
        }
    }
}
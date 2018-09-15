using App2_ListaUF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2_ListaUF
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Estados : ContentPage
	{
		public Estados ()
		{
			InitializeComponent ();

            Listaestado.ItemsSource = Service.Service.getEstados();
		}

        private void SelecaoEstadoAction(object sender, SelectedItemChangedEventArgs e)
        {
           Estado estado = (Estado)e.SelectedItem;

            Navigation.PushAsync(new Municipios(estado));
        }
    }
}
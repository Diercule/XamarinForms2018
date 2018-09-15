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
	public partial class Municipios : ContentPage
	{
        private List<Municipio> ListaInternaMunicipio { get; set; }
        public List<Municipio> ListaFiltradaMunicipio { get; set; }

        public Municipios (Estado est)
		{
			InitializeComponent ();

            ListaInternaMunicipio = Service.Service.getMunicipio(est.id);

            LisMun.ItemsSource = ListaInternaMunicipio;

        }

        private void BuscaRapida(object sender, TextChangedEventArgs e)
        {
            ListaFiltradaMunicipio =  ListaInternaMunicipio.Where(a => a.nome.Contains(e.NewTextValue)).ToList();
            LisMun.ItemsSource = ListaFiltradaMunicipio;
        }
    }
}
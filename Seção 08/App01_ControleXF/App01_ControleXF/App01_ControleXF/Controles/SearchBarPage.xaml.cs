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
	public partial class SearchBarPage : ContentPage
	{
        private List<String> empresaTi; 

        public SearchBarPage ()
		{
			InitializeComponent ();

            empresaTi = new List<string>();
            empresaTi.Add("Microsoft");
            empresaTi.Add("Apple");
            empresaTi.Add("Oracle");
            empresaTi.Add("IBM");
            empresaTi.Add("Sap");
            empresaTi.Add("Uber");
            empresaTi.Add("99Taxi");

            Preencher(empresaTi);

        }

        private void Preencher(List<String> empresaTi)
        {
            ListResults.Children.Clear();
            foreach (var emp in empresaTi)
            {
                ListResults.Children.Add(new Label { Text = emp });
            }
        }

        private void Pesquisar(object sender, TextChangedEventArgs e)
        {
            var result = empresaTi.Where(a => a.Contains(e.NewTextValue)).ToList<String>();
            Preencher(result);
        }
    }
}
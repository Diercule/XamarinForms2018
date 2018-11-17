using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1_Vagas.Modelo;

namespace App1_Vagas.Paginas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetelhaVaga : ContentPage
	{
		public DetelhaVaga (Vaga vaga)
		{
			InitializeComponent ();
            BindingContext = vaga;
		}
	}
}
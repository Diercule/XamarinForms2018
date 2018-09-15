using App1_Cell.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_Cell.Paginas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewButtonPage : ContentPage
	{
		public ListViewButtonPage ()
		{
			InitializeComponent ();

            List<Funcionario> funcionarios = new List<Funcionario>();
            funcionarios.Add(new Funcionario() { Nome = "José", Cargo = "Presidente" });
            funcionarios.Add(new Funcionario() { Nome = "Maria", Cargo = "Gerente de Vendas" });
            funcionarios.Add(new Funcionario() { Nome = "Elaine", Cargo = "Gerente de Marketing" });
            funcionarios.Add(new Funcionario() { Nome = "Felipe", Cargo = "Entregador" });
            funcionarios.Add(new Funcionario() { Nome = "João", Cargo = "Vendedor" });

            ListFunc.ItemsSource = funcionarios;
        }

        private void FeriasAction(object sender, EventArgs e)
        {
            Button btnFerias = (Button)sender;
            Funcionario func = (Funcionario)btnFerias.CommandParameter;

            DisplayAlert("Ferias", "Funcionario: " + func.Nome, "OK");
        }
    }
}
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
	public partial class ListViewPage : ContentPage
	{
		public ListViewPage ()
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

        private void ItemSelecionadoAction(object sender, SelectedItemChangedEventArgs e)
        {
            Funcionario func = (Funcionario)e.SelectedItem;

            Navigation.PushAsync(new Detalhe.DetailPage(func));
        }

        private void AbonoAction(object sender, EventArgs e)
        {

        }

        private void FeriasAction(object sender, EventArgs e)
        {
            MenuItem botao = (MenuItem)sender;
            Funcionario func = (Funcionario)botao.CommandParameter;

            DisplayAlert("Titulo: "+func.Nome, "Mensagem: "+ func.Nome + " - " + func.Cargo,"OK");
        }
    }
}
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
	public partial class ViewCellPage : ContentPage
	{
		public ViewCellPage ()
		{
			InitializeComponent ();


            List<Funcionario> funcionarios = new List<Funcionario>();
            funcionarios.Add(new Funcionario() { Foto = "https://cdn.pixabay.com/photo/2017/02/23/13/05/profile-2092113_960_720.png", Nome = "José", Cargo = "Presidente" });
            funcionarios.Add(new Funcionario() { Foto = "https://cdn.pixabay.com/photo/2012/04/13/00/21/lady-31217_960_720.png", Nome = "Maria", Cargo = "Gerente de Vendas" });
            funcionarios.Add(new Funcionario() { Foto = "https://www.shareicon.net/data/256x256/2016/09/01/822729_user_512x512.png", Nome = "Elaine", Cargo = "Gerente de Marketing" });
            funcionarios.Add(new Funcionario() { Foto = "https://publicdomainvectors.org/photos/people-man-blue-shirt.png", Nome = "Felipe", Cargo = "Entregador" });
            funcionarios.Add(new Funcionario() { Foto = "https://publicdomainvectors.org/photos/people-man-blue-shirt.png", Nome = "João", Cargo = "Vendedor" });

            ListFunc.ItemsSource = funcionarios;
        }
	}
}
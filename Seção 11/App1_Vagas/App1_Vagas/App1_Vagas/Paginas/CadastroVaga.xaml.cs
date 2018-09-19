using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1_Vagas.Modelo;
using App1_Vagas.Banco;

namespace App1_Vagas.Paginas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CadastroVaga : ContentPage
	{
		public CadastroVaga ()
		{
			InitializeComponent ();
		}

        private void Salvar(object sender, EventArgs e)
        {
            //TODO - Valdiar Dados do Cadastro
            Vaga vaga = new Vaga();
            vaga.NomeVaga = Nomevaga.Text;
            vaga.Empresa = empresa.Text;
            vaga.Quantidade = short.Parse(quantidade.Text);
            vaga.Salario = double.Parse(salario.Text);
            vaga.Descricao = desc.Text;
            vaga.Cidade = cidade.Text;
            vaga.Email = email.Text;
            vaga.Telefone = telefone.Text;
            vaga.Contrato = (tipoContrato.IsToggled) ? "PJ" : "CLT";

            DataBase dataBase = new DataBase();
            dataBase.Cadastro(vaga);

            Navigation.PopAsync();

        }
    }
}
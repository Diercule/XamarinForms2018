using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App01_ConsultarCep.Serviço.Modelo;
using App01_ConsultarCep.Serviço;

namespace App01_ConsultarCep
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            Botao.Clicked += BuscarCep;
		}

        private void BuscarCep(object sender, EventArgs args)
        {
            //TODO - Lógica do Programa

            //TODO  - validações

            string cep = Cep.Text.Trim();
            if (isValidCep(cep))
            {
                try
                {
                    Endereco end = ViaCepServico.BuscarEnderecoViaCep(cep);

                    if (end != null)
                    {
                        Result.Text = string.Format("Endereço: {2} de {3} {0} {1}", end.localidade, end.uf, end.logradouro, end.bairro);
                    }
                    else
                    {
                        DisplayAlert("ERRO", "O Endereço não foi encontrado para o CEP informado: " + Cep.Text, "OK");
                    }
                }catch(Exception e)
                {
                    DisplayAlert("ERRO CRITICO", e.Message, "OK");
                }
            }
        }

        private bool isValidCep(string cep)
        {
            bool valido = true;
            if(cep.Length != 8)
            {
                DisplayAlert("ERRO", "Cep Invalido!! O CEP deve conter 8 carcteres", "OK");
                valido = false;
            }

            int NovoCep = 0;
            if(!int.TryParse(cep, out NovoCep))
            {
                DisplayAlert("ERRO", "Cep Invalido!! O CEP deve ser composto apenas por números", "OK");
                valido = false;
            }
            return valido;
        }
	}
}

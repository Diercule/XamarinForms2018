using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Aoo2_Tarefa.Model;

namespace Aoo2_Tarefa.Telas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Cadastro : ContentPage
	{
        private byte Prioridade { get; set; }
		public Cadastro ()
		{
			InitializeComponent ();
		}

        private void PrioridadeSelectAction(object sender, EventArgs e)
        {
            var Stacks = SLPrioridade.Children;
            foreach (var Linha in Stacks)
            {
                Label LblPrioridade = ((StackLayout)Linha).Children[1] as Label;
                LblPrioridade.TextColor = Color.Gray;
            }

           ((Label)((StackLayout)sender).Children[1]).TextColor = Color.Black;
            FileImageSource Source = ((Image)((StackLayout)sender).Children[0]).Source as FileImageSource;
            String Prioridade = Source.File.ToString().Replace("Resources/", "").Replace(".png", "").Replace("p","");
            this.Prioridade = byte.Parse(Prioridade);
        }

        private void SalvarAction(object sender, EventArgs e)
        {
            bool ErroExiste = false;
            if(!(TxtNome.Text.Trim().Length > 0))
            {
                ErroExiste = true;
                DisplayAlert("ERRO", "Nome não preenchido!", "Ok");
            }

            if(!(this.Prioridade > 0))
            {
                ErroExiste = true;
                DisplayAlert("ERRO", "Prioridade não foi Informada!", "OK");
            }

            if (ErroExiste == false)
            {
                Tarefa tarefa = new Tarefa();
                tarefa.Nome = TxtNome.Text.Trim();
                tarefa.Prioridade = this.Prioridade;

                new GerenciadorTarefa().Salvar(tarefa);
                App.Current.MainPage = new NavigationPage(new Telas.Inicio());
            }
        }
    }
}
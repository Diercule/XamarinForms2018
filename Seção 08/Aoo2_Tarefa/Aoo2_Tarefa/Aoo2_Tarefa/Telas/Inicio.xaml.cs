using Aoo2_Tarefa.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aoo2_Tarefa.Telas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Inicio : ContentPage
	{
		public Inicio ()
		{
			InitializeComponent ();
            DataHoje.Text = DateTime.Now.DayOfWeek.ToString() + "," + DateTime.Now.ToString("dd/MM");
		}

        private void ActionGoCad(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Cadastro());
        }

        public void LinhaStackLayout(Tarefa tarefa)
        {
            Image Check = new Image()
            {
                VerticalOptions = LayoutOptions.Center,
                Source = ImageSource.FromFile("CheckOff.png")
            };
            if (Device.RuntimePlatform == Device.UWP)
            {
                Check.Source = ImageSource.FromFile("Resource/CheckOff.png");
            }

            View StackCentral = null;
            if (tarefa.DataFinalizacao == null)
            {
                StackCentral = new Label()
                {
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    Text = tarefa.Nome
                };
            }
            else
            {
                StackCentral = new StackLayout()
                {
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    Spacing = 0
                };
                ((StackLayout)StackCentral).Children.Add(new Label() { Text = tarefa.Nome, TextColor = Color.Gray});
                ((StackLayout)StackCentral).Children.Add(new Label() { Text = tarefa.Nome, TextColor = Color.Gray });
                ((StackLayout)StackCentral).Children.Add(new Label() { Text = "Finalizado"+tarefa.DataFinalizacao.ToString("dd/MM/yyyy - hh:mm"+ "h"), TextColor = Color.Gray, FontSize = 10 });
            }

            StackLayout Linha = new StackLayout()
            {
                Orientation = StackOrientation.Horizontal,
                Spacing = 15,
            };


            Image Prioridade = new Image()
            {
                VerticalOptions = LayoutOptions.Center,
                Source = ImageSource.FromFile("p"+tarefa.Prioridade+".png")
            };
            if (Device.RuntimePlatform == Device.UWP)
            {
                Check.Source = ImageSource.FromFile("Resource/"+tarefa.Prioridade+".png");
            }

            Image Delete = new Image()
            {
                VerticalOptions = LayoutOptions.Center,
                Source = ImageSource.FromFile("Delete.png")
            };
            if (Device.RuntimePlatform == Device.UWP)
            {
                Check.Source = ImageSource.FromFile("Resource/Delete.png");
            }

            Linha.Children.Add(Check);
            Linha.Children.Add(StackCentral);
            Linha.Children.Add(Prioridade);
            Linha.Children.Add(Delete);

            SLTarefas.Children.Add(Linha);
        }
    }
}
using App1_Vagas.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_Vagas.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Consulta : ContentPage
    {
        public Consulta()
        {
            InitializeComponent();
        }

        private void Cadastrar(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CadastroVaga());
        }

        private void MinhasVagas(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MinhasVagasCadastradas());
        }

        private void MaisDetalhe(object sender, EventArgs e)
        {
            Label lblDetalhe = (Label)sender;
            Vaga vaga = (Vaga)((TapGestureRecognizer)lblDetalhe.GestureRecognizers[0]).CommandParameter;
            Navigation.PushAsync(new DetelhaVaga(vaga));
        }
    }
}
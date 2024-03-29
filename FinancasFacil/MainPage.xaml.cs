using Dominio.Entidades;
using Integracao;
using Newtonsoft.Json;
namespace FinancasFacil
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        
        public MainPage()
        {
            InitializeComponent();
        }

        private async void CliqueBuscarInformacoes(object sender, EventArgs e)
        {
            string simboloAcao = campoSimbolo.Text;
            ShareDetails shareDetails = new ShareDetails(simboloAcao);
            await Navigation.PushAsync(shareDetails);
            SemanticScreenReader.Announce(BuscarInformacoes.Text);
        }
    }

}

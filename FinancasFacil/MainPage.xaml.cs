using Dominio.Entidades;
using Integracao;
using Newtonsoft.Json;
namespace FinancasFacil
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        private readonly BaseClient _client = new BaseClient();
        public MainPage()
        {
            InitializeComponent();
        }

        private async void CliqueBuscarInformacoes(object sender, EventArgs e)
        {
            string simboloAcao = campoSimbolo.Text;
            
            HttpResponseMessage respostaAPI = await _client.GetShare(simboloAcao);
            string conteudo = await respostaAPI.Content.ReadAsStringAsync();
            Acao acao = JsonConvert.DeserializeObject<Acao>(conteudo);

            BuscarInformacoes.Text = $"{acao.ShortName} Valor: {acao.RegularMarketPrice}";

            SemanticScreenReader.Announce(BuscarInformacoes.Text);
        }
    }

}

using Dominio.Entidades;
using Integracao;
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

        private void CliqueBuscarInformacoes(object sender, EventArgs e)
        {
            string simboloAcao = campoSimbolo.Text;
            
            dynamic acao = _client.GetShare(simboloAcao);

            SemanticScreenReader.Announce(BuscarInformacoes.Text);
        }
    }

}

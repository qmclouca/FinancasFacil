using Dominio.Entidades;
using Newtonsoft.Json;

namespace FinancasFacil;

public partial class ShareDetails : ContentPage
{
    private string _shareSymbol;
    private readonly BaseClient _client = new BaseClient();

    public ShareDetails(string shareSymbol)
    {
        InitializeComponent(); // Isso deve vir primeiro
        _shareSymbol = shareSymbol;
        ShowShareDetails(_shareSymbol);
    }

    public async Task ShowShareDetails(string shareSymbol)
    {
        try
        {
            HttpResponseMessage respostaAPI = await _client.GetShare(shareSymbol);
            string conteudo = await respostaAPI.Content.ReadAsStringAsync();
            Acao acao = JsonConvert.DeserializeObject<Acao>(conteudo);

            MainThread.BeginInvokeOnMainThread(() =>
            {
                Logotipo.Source = acao.Logourl;
                Dados.Text = $"{acao.ShortName} Valor: {acao.RegularMarketPrice}";
            });
        }
        catch (Exception ex)
        {
            // Tratar exceção (por exemplo, mostrando uma mensagem para o usuário)
            MainThread.BeginInvokeOnMainThread(() =>
            {
                // Atualizar a UI para refletir o erro
            });
        }
    }
}

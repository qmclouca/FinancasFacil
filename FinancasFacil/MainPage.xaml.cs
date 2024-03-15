using Dominio.Entidades;

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

        private void OnCounterClicked(object sender, EventArgs e)
        {
            Acao acao = _client.GetShare("PETR4");
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}

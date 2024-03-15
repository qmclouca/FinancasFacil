namespace FinancasFacil
{
    public  class BaseClient
    {
        static readonly HttpClient _client = new HttpClient();
        string _baseUrl = "https://tg01dj7m-7029.brs.devtunnels.ms/";
        
        public async Task GetShare(string shareSymbol) 
        {
            HttpResponseMessage response = await _client.GetAsync(_baseUrl + $"Share/{shareSymbol}");
        }
    }
}

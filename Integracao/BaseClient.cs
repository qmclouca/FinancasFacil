

namespace FinancasFacil
{
    public  class BaseClient
    {
        static readonly HttpClient _client = new HttpClient();
        string _baseUrl = "https://4r2dzsth-7029.brs.devtunnels.ms/";
                           
        public async Task<HttpResponseMessage> GetShare(string shareSymbol) 
        {
            string end = _baseUrl  + "Share/" + shareSymbol;    
            HttpResponseMessage response = await _client.GetAsync(end);
            return response;        
        }
    }
}

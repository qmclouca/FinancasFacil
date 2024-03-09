using Newtonsoft.Json;

namespace Dominio
{
    // All the code in this file is included in all platforms.
    public class Acao
    {
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("twoHundredDayAverage")]
        public double TwoHundredDayAverage { get; set; }

        [JsonProperty("twoHundredDayAverageChange")]
        public double TwoHundredDayAverageChange { get; set; }

    }
}


using Newtonsoft.Json;

namespace Dominio.Entidades
{
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

        [JsonProperty("twoHundredDayAverageChangePercent")]
        public double TwoHundredDayAverageChangePercent { get; set; }

        [JsonProperty("marketCap")]
        public long MarketCap { get; set; }

        [JsonProperty("shortName")]
        public string ShortName { get; set; }

        [JsonProperty("longName")]
        public string LongName { get; set; }

        [JsonProperty("regularMarketChange")]
        public double RegularMarketChange { get; set; }

        [JsonProperty("regularMarketChangePercent")]
        public double RegularMarketChangePercent { get; set; }

        [JsonProperty("regularMarketTime")]
        public string RegularMarketTime { get; set; }

        [JsonProperty("regularMarketPrice")]
        public double RegularMarketPrice { get; set; }

        [JsonProperty("regularMarketDayHigh")]
        public double RegularMarketDayHigh { get; set; }

        [JsonProperty("regularMarketDayRange")]
        public string RegularMarketDayRange { get; set; }

        [JsonProperty("regularMarketDayLow")]
        public double RegularMarketDayLow { get; set; }

        [JsonProperty("regularMarketVolume")]
        public long RegularMarketVolume { get; set; }

        [JsonProperty("regularMarketPreviousClose")]
        public double RegularMarketPreviousClose { get; set; }

        [JsonProperty("regularMarketOpen")]
        public double RegularMarketOpen { get; set; }

        [JsonProperty("averageDailyVolume3Month")]
        public double RegularMarketClose { get; set; }

        [JsonProperty("averageDailyVolume10Day")]
        public double AverageDailyVolume10Day { get; set; }

        [JsonProperty("fiftyTwoWeekLowChange")]
        public double FiftyTwoWeekLowChange { get; set; }

        [JsonProperty("fiftyTwoWeekLowChangePercent")]
        public double FiftyTwoWeekLowChangePercent { get; set; }

        [JsonProperty("fiftyTwoWeekRange")]
        public string FiftyTwoWeekRange { get; set; }

        [JsonProperty("fiftyTwoWeekHighChange")]
        public double FiftyTwoWeekHighChange { get; set; }

        [JsonProperty("fiftyTwoWeekHighChangePercent")]
        public double FiftyTwoWeekHighChangePercent { get; set; }

        [JsonProperty("fiftyTwoWeekLow")]
        public double FiftyTwoWeekLow { get; set; }

        [JsonProperty("fiftyTwoWeekHigh")]
        public double FiftyTwoWeekHigh { get; set; }

        [JsonProperty("priceEarnings")]
        public double PriceEarnings { get; set; }

        [JsonProperty("earningsPerShare")]
        public double EarningsPerShare { get; set; }

        [JsonProperty("logourl")]
        public string Logourl { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }
    }
}
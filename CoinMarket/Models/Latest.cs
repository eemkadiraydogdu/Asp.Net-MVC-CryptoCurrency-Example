using System.Text.Json.Nodes;

namespace CoinMarket.Models
{
    public class Latest
    {
        public int id { get; set; }
        public string name { get; set; }
        public string symbol { get; set; }
        public string slug { get; set; }
        public int num_market_pairs { get; set; }
        public string date_added { get; set; }
        public JsonArray tags { get; set; }
        public int max_supply { get; set; }
        public int circulating_supply { get; set;}
        public int total_supply { get; set;}
        public string? platform { get; set;}
        public int cmc_rank { get; set;}
        public string? self_reported_circulating_supply { get; set; }
        public string? self_reported_market_cap { get; set; }
        public string? tv_ratio { get; set; }
        public string last_updated { get; set; }
        public JsonObject quote { get; set; }

    }
}

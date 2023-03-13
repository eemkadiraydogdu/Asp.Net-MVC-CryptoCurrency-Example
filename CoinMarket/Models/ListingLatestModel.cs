using System.Text.Json.Nodes;

namespace CoinMarket.Models
{
    public class ListingLatestModel
    {
        public List<Status> status {  get; set; }
        public List<Latest> data { get; set; }
    }
}

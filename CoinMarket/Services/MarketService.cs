using CoinMarket.Models;
using Newtonsoft.Json;
using RestSharp;
using System.Text.Json.Nodes;

namespace CoinMarket.Services
{
    public class MarketService
    {
        public CryptoResultModel Cryptos()
        {
            var url = "https://api.collectapi.com/economy/cripto";
            var client = new RestClient(url);
            var request = new RestRequest(url, Method.Get);
            request.AddHeader("authorization", "apikey 65aMQCEPddUEsZprL4C2D0:58G8aJiCDT5JYMWlakXQPo");
            request.AddHeader("content-type", "application/json");
            var response = client.Execute(request);
            var cryptos = JsonConvert.DeserializeObject<CryptoResultModel>(response.Content);
            return cryptos;
        }
    }
}

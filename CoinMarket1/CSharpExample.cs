using CoinMarketCap.Models.Cryptocurrency;
using CoinMarketCap;
using System;
using System.Net;
using System.Web;
using RestSharp;
using Newtonsoft.Json;

class CSharpExample
{
    private static string API_KEY = "b54bcf4d-1bca-4e8e-9a24-22ff2c3d462c";

    public static void Main(string[] args)
    {
        try
        {
            Test();
            //Console.WriteLine(makeAPICall());

        }
        catch (WebException e)
        {
            Console.WriteLine(e.Message);
            
        }
    }

    public async static void Test()
    {
        //var client = new RestClient("https://api.collectapi.com/economy/borsaIstanbul");
        //var request = new RestRequest(Method.Get.ToString());
        //request.AddHeader("authorization", "apikey 65aMQCEPddUEsZprL4C2D0:58G8aJiCDT5JYMWlakXQPo");
        //request.AddHeader("content-type", "application/json");
        //RestResponse response = client.Execute(request);
        //Console.WriteLine(response.ToString());
        //var url = "https://api.collectapi.com/economy/goldPrice";
        //var client = new RestClient(url);
        //var request = new RestRequest(url,Method.Get);
        //request.AddHeader("authorization", "apikey 65aMQCEPddUEsZprL4C2D0:58G8aJiCDT5JYMWlakXQPo");
        //request.AddHeader("content-type", "application/json");
        //RestResponse response = client.Execute(request);
        //var url = "https://api.collectapi.com/economy/cripto";
        //var client = new RestClient(url);
        //var request = new RestRequest(url, Method.Get);
        //request.AddHeader("authorization", "apikey 65aMQCEPddUEsZprL4C2D0:58G8aJiCDT5JYMWlakXQPo");
        //request.AddHeader("content-type", "application/json");
        //var response = client.Execute(request);
        var url = "https://api.collectapi.com/economy/cripto?data.name=Bitcoin";
        var client = new RestClient(url);
        var request = new RestRequest(url,Method.Get);
        request.AddHeader("authorization", "apikey 65aMQCEPddUEsZprL4C2D0:58G8aJiCDT5JYMWlakXQPo");
        request.AddHeader("content-type", "application/json");
        var response = client.Execute(request);
        Console.WriteLine(JsonConvert.DeserializeObject(response.Content));
        //var url = "https://api.collectapi.com/credit/creditBid?data.price=100000&data.month=12&data.query=ihtiyac";
        //var client = new RestClient(url);
        //var request = new RestRequest(url,Method.Get);
        //request.AddHeader("authorization", "apikey 65aMQCEPddUEsZprL4C2D0:58G8aJiCDT5JYMWlakXQPo");
        //request.AddHeader("content-type", "application/json");
        //var response = client.Execute(request);
        //Console.WriteLine(JsonConvert.DeserializeObject(response.Content));
        //var client = new CoinMarketCapClient(API_KEY);
        //var listingsResponse = await client.GetCryptocurrencyIdMapAsync(new IdMapParameters { Symbol = "LINK" }, CancellationToken.None);
    }
    static string makeAPICall()
    {
        var URL = new UriBuilder("https://sandbox-api.coinmarketcap.com/v1/cryptocurrency/listings/latest");

        var queryString = HttpUtility.ParseQueryString(string.Empty);
        queryString["start"] = "1";
        queryString["limit"] = "5000";
        queryString["convert"] = "USD";

        URL.Query = queryString.ToString();

        var client = new WebClient();
        client.Headers.Add("X-CMC_PRO_API_KEY", API_KEY);
        client.Headers.Add("Accepts", "application/json");
        return client.DownloadString(URL.ToString());

    }

}

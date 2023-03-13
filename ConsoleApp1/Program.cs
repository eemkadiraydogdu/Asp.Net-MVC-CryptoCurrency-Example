using CoinMarket.Models;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Text.Json.Nodes;
using System.Web;

class CSharpExample
{
    private static string API_KEY = "7f153db3-c6da-4de5-80c3-266877659d68";

    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine(makeAPICall());
        }
        catch (WebException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    static string makeAPICall()
    {
        var URL = new UriBuilder("https://pro-api.coinmarketcap.com/v1/cryptocurrency/listings/latest");

        var queryString = HttpUtility.ParseQueryString(string.Empty);
        queryString["start"] = "1";
        queryString["limit"] = "5000";
        queryString["convert"] = "USD";

        URL.Query = queryString.ToString();

        var client = new WebClient();
        client.Headers.Add("X-CMC_PRO_API_KEY", API_KEY);
        client.Headers.Add("Accepts", "application/json");
        var result = client.DownloadString(URL.ToString());
        var jsonObject = JsonNode.Parse(result).AsObject();
        var listingLatestModel = JsonConvert.DeserializeObject<ListingLatestModel>(result);
        return result;

    }

}
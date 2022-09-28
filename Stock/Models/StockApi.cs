using Azure.Core;

namespace Stock.Models
{
    public class StockApi
    {

        var client = new RestClient("https://alpha-vantage.p.rapidapi.com/query?interval=5min&function=TIME_SERIES_INTRADAY&symbol=MSFT&datatype=json&output_size=compact");
        var request = new RestRequest(Method.GET);
        Request.AddHeader("X-RapidAPI-Key", "fe96c29976msh7164fa7f072bef1p19efc6jsn0ad83cbe2bb2");
        request.AddHeader("X-RapidAPI-Host", "alpha-vantage.p.rapidapi.com");
        IRestResponse response = client.Execute(request);


    }
}

















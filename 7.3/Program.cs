using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace tehtava73;
class Program
{
    static async Task Main()
    {
        await ProcessData();
    }

    
    private static async Task ProcessData()
    {
        HttpClient client = new HttpClient();
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(
        new MediaTypeWithQualityHeaderValue("application/json"));

        var stringTask = await client.GetStreamAsync("https://api.porssisahko.net/v1/price.json?date=2023-11-12&hour=23");
        var sahko = await JsonSerializer.DeserializeAsync<Sahko>(await stringTask);
        Console.WriteLine(sahko.Price);
    }
}
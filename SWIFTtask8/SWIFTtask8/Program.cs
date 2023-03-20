using System;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;


// ფაილები იქმნება SWIFTtask8\bin\Debug\net6.0  დირექტორიაში
public class Program
{
    static void Main()
    {
        GenerateCountryDataFiles();
    }

    static void GenerateCountryDataFiles()
    {
        string url = "https://restcountries.com/v3.1/all";
        WebClient client = new WebClient();
        string json = client.DownloadString(url);
        JArray countries = JArray.Parse(json);
        //Console.WriteLine(countries);
        foreach (JToken country in countries)
        {
            string countryName = country["name"]["common"].ToString();
            string region = country["region"].ToString();
            string latlng = string.Join(", ", country["latlng"].ToObject<double[]>());
            string area = country["area"].ToString();
            string population = country["population"].ToString();

            string filename = $"{countryName}.txt";
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine($"Country: {countryName}");
                writer.WriteLine($"Region: {region}");
                writer.WriteLine($"Latitude and Longitude: {latlng}");
                writer.WriteLine($"Area: {area}");
                writer.WriteLine($"Population: {population}");

            }

        }

    }
}

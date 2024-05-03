using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using WeatherApp;
using Newtonsoft.Json;

namespace WeatherApp
{

    public class Root
    {
        public string name { get; set; }
        public double lat { get; set; }
        public double lon { get; set; }
        public string country { get; set; }
        public string state { get; set; }
    }
}

class Geocoder
    {
        public async Task<(double, double)> GetCoordinates(string cityName)
        {
            double lat = 0;
            double lon = 0;
            const string APIkey = "d3ef0c3f4447a9a32725a0f2850fbe0a";
            
            string stateCode = "MA";
            string countryCode = "US";
            int limit = 1;
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync($"http://api.openweathermap.org/geo/1.0/direct?q={cityName},{stateCode},{countryCode}&limit={limit}&appid={APIkey}");
            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                List<Root> locations = JsonConvert.DeserializeObject<List<Root>>(responseBody);
            
            foreach (var location in locations)
            {
                lat = location.lat;
                lon = location.lon;
            }

        }
            else
            {
                Console.WriteLine("API call failed");
            }
            return (lat, lon);
        }
    }


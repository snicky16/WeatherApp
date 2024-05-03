using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherApp;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public async void button1_Click(object sender, EventArgs e)
        {
            getWeather();
        }
        async void getWeather()
        {
            {
                const string APIkey = "d3ef0c3f4447a9a32725a0f2850fbe0a";
                Geocoder geocoder = new Geocoder();
                (double lat, double lon) = await geocoder.GetCoordinates(textBox1.Text);

                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync($"https://api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}&units=imperial&appid={APIkey}");
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    WeatherInfo.Root2 info = JsonConvert.DeserializeObject<WeatherInfo.Root2>(responseBody);
                    labTemp.Text = info.main.temp.ToString();
                    labCondition.Text = info.weather[0].main;
                    labWind.Text = info.wind.speed.ToString();
                }
            }
        }
    }
}

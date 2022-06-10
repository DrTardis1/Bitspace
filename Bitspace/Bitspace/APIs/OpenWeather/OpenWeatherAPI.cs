using System;
using Bitspace.APIs.OpenWeather.Responses;
using Newtonsoft.Json;

namespace Bitspace.APIs.OpenWeather
{
    public class OpenWeatherAPI : IOpenWeatherService
    {
        private const string APIKEY = "2366c9edf1524154fa6982430cacdb30";

        private IHttpClient _client;
        public OpenWeatherAPI(IHttpClient client)
        {
            _client = client;
        }

        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public async void GetCurrentWeather()
        {
            var url = new Uri($"https://api.openweathermap.org/data/2.5/weather?units=metric&lat={Latitude}&lon={Longitude}&appid={APIKEY}");
            var response = await _client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<CurrentWeatherResponse>(content);
        }
    }
}

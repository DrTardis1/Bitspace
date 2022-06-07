using System;

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
            var url = new Uri($"https://api.openweathermap.org/data/3.0/onecall?lat={Latitude}&lon={Longitude}&appid={APIKEY}");
            var response = await _client.GetAsync(url);
        }
    }
}

using System.Collections.Generic;
using Newtonsoft.Json;

namespace Bitspace.APIs.OpenWeather.Responses
{
    public class CurrentWeatherResponse
    {
        [JsonProperty("lat")]
        public float Latitude { get; set; }

        [JsonProperty("lon")]
        public float Longitude { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("timezone_offset")]
        public float TimezoneOffset { get; set; }

        [JsonProperty("dt")]
        public float DT { get; set; }

        [JsonProperty("sunrise")]
        public float Sunrise { get; set; }

        [JsonProperty("sunset")]
        public float Sunset { get; set; }

        [JsonProperty("temp")]
        public decimal Temperature { get; set; }

        [JsonProperty("feels_like")]
        public decimal FeelsLike { get; set; }

        [JsonProperty("pressure")]
        public int Pressure { get; set; }

        [JsonProperty("humidity")]
        public int Humidity { get; set; }

        [JsonProperty("dew_point")]
        public decimal DewPoint { get; set; }

        [JsonProperty("uvi")]
        public decimal UVI { get; set; }

        [JsonProperty("clouds")]
        public int Clouds { get; set; }

        [JsonProperty("visibility")]
        public int Visibility { get; set; }

        [JsonProperty("wind_speed")]
        public decimal WindSpeed { get; set; }

        [JsonProperty("wind_deg")]
        public decimal WindDegrees { get; set; }

        [JsonProperty("wind_gust")]
        public decimal WindGust { get; set; }

        [JsonProperty("weather")]
        public List<WeatherObject> Weather { get; set; }
    }
}

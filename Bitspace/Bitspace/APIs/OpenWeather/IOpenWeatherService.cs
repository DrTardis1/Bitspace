namespace Bitspace.APIs.OpenWeather
{
    public interface IOpenWeatherService
    {
        double Latitude { get; set; }
        double Longitude { get; set; }
        void GetCurrentWeather();
    }
}

using Bitspace.APIs.OpenWeather;
using Prism.Navigation;

namespace Bitspace.Pages.Mainpage
{
    public class MainPageViewModel : BasePageViewModel
    {
        private readonly IOpenWeatherService _openWeatherService;
        public MainPageViewModel(
            INavigationService navigationService,
            IOpenWeatherService openWeatherService)
            : base(navigationService)
        {
            _openWeatherService = openWeatherService;
            openWeatherService.Latitude = -33.0120867;
            openWeatherService.Longitude = 151.7144379;
            openWeatherService.GetCurrentWeather();
            Title = "Main Page";
        }
    }
}

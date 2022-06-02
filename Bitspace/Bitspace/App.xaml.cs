using Bitspace.Constants;
using Bitspace.Services;
using Bitspace.ViewModels;
using Bitspace.Views;
using Prism;
using Prism.Ioc;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace Bitspace
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync($"NavigationPage/{NavigationConstants.Mainpage}");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            RegisterServices(containerRegistry);
            RegisterNavigation(containerRegistry);
        }

        private void RegisterServices(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();
            containerRegistry.RegisterSingleton<IDeviceInformationService, DeviceInformationService>();
        }

        private void RegisterNavigation(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>(NavigationConstants.Mainpage);
        }
    }
}

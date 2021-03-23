using FoodFight.DAL;
using FoodFight.DAL.Services;
using FoodFight.Domain.Models;
using FoodFight.Domain.Services;
using FoodFight.ViewModels;
using FoodFight.Views;
using Prism;
using Prism.DryIoc;
using Prism.Ioc;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace FoodFight
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

            await NavigationService.NavigateAsync("MainPage?selectedTab=Home");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();


            
            containerRegistry.RegisterSingleton<IDataService<User>, GenericDataService<User>>();
            containerRegistry.RegisterScoped<DbContextFactory>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<Profile, ProfileViewModel>();
            containerRegistry.RegisterForNavigation<Settings, SettingsViewModel>();
            containerRegistry.RegisterForNavigation<Contacts, ContactsViewModel>();
            containerRegistry.RegisterForNavigation<Favorites, FavoritesViewModel>();
            containerRegistry.RegisterForNavigation<Home, HomeViewModel>();
            containerRegistry.RegisterForNavigation<Start, StartViewModel>();

            PrismContainerExtension.Current.RegisterServices(s => {

            });
        }
    }
}

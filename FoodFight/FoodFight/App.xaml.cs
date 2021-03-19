using FoodFight.Views.Forms;
using System;
using FoodFight.BusinessLayer;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.Extensions.DependencyInjection;
using FoodFight.ViewModels;
using System.Data;
using System.Data.SqlClient;

namespace FoodFight
{
    public partial class App : Application
    {
        public App()
        {
            Device.SetFlags(new string[] { "Shapes_Experimental" });

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDA2NTI3QDMxMzgyZTM0MmUzMEx4dUs5V2w0MHBHUzdndkZJV2RUUE9Ma01NQ2h5SVhQUEdFOHk2anRhT3c9");
            InitializeComponent();

            MainPage = new LoginPage();

        }

        protected override void OnStart()
        {

        }

        //IServiceProvider OnStartup()
        //{
        //    IServiceProvider serviceProvider = CreateServiceProvider();
        //    serviceProvider.GetRequiredService<BaseViewModel>();
        //    return serviceProvider;
        //}

        //IServiceProvider CreateServiceProvider()
        //{
        //    IServiceCollection services = new ServiceCollection();

        //    services.AddScoped<BaseViewModel>();

        //    return services.BuildServiceProvider();
        //}



        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

using FoodFight.Views.Forms;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodFight
{
    public partial class App : Application
    {
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDA2NTI3QDMxMzgyZTM0MmUzMEx4dUs5V2w0MHBHUzdndkZJV2RUUE9Ma01NQ2h5SVhQUEdFOHk2anRhT3c9");
            InitializeComponent();

            MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

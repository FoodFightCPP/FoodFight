using FoodFight.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodFight
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {
        public IServiceProvider ServiceProvider { get; set; }

        public AppShell()
        {
            //ServiceProvider = serviceProvider;
            InitializeComponent();
            Init();
            //ServiceProvider.GetService<BaseViewModel>();
            
        }

        private void Init()
        {
            FlyoutTab.CurrentItem = HomeTab;
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Windows.Input;
using FoodFight.DAL;
using FoodFight.Views.Forms;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace FoodFight.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public HomeViewModel()
        {
            PressMeCommand = new Command(SomeCommand);
        }

        public ICommand PressMeCommand { get; set; }

        private async static void SomeCommand()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new LoginPage());
        }


    }
}

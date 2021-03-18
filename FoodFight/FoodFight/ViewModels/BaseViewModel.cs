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
    /// <summary>
    /// This viewmodel extends in another viewmodels.
    /// </summary>
    [Preserve(AllMembers = true)]
    [DataContract]
    public class BaseViewModel : ObservableObject
    {

        #region Constructor

        public BaseViewModel()
        {
            MenuItemOneCommand = new Command(SomeCommand);
        }

        #endregion

        public ICommand MenuItemOneCommand { get; set; }

        private async static void SomeCommand()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new LoginPage());
        }
    }
}

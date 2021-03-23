using FoodFight.Domain.Models;
using FoodFight.Domain.Services;
using Newtonsoft.Json;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FoodFight.ViewModels
{
    public class ContactsViewModel : BindableBase
    {

        IDataService<User> _userRepo { get; set; }

        ObservableCollection<User> _users;

        public ObservableCollection<User> AppUsers { 
            get => _users;
            set => SetProperty(ref _users, value);
        }

        public ContactsViewModel(IDataService<User> userRepo)
        {
            _userRepo = userRepo;
            AppUsers = new ObservableCollection<User>();
            TestRepo();
        }

        public async void TestRepo()
        {
            HttpClient httpClient = new HttpClient();

            var result = await httpClient.GetStringAsync("https://foodfightwebapi.azurewebsites.net/api/Users");
            AppUsers = new ObservableCollection<User>(JsonConvert.DeserializeObject<User[]>(result));
        }
    }
}

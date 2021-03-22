using FoodFight.Domain.Models;
using FoodFight.Domain.Services;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace FoodFight.ViewModels
{
    public class ContactsViewModel : BindableBase
    {

        IDataService<User> _userRepo { get; set; }

        ObservableCollection<User> _users;

        public ObservableCollection<User> Users { get; set; }

        public ContactsViewModel(IDataService<User> userRepo)
        {
            _userRepo = userRepo;
            Users = new ObservableCollection<User>();
            TestRepo();
        }

        public async void TestRepo()
        {
            Users = new ObservableCollection<User>(await _userRepo.GetAll());
        }
    }
}

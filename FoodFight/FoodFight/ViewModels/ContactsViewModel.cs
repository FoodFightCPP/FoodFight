using FoodFight.Domain.Models;
using FoodFight.Domain.Services;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodFight.ViewModels
{
    public class ContactsViewModel : BindableBase
    {

        IDataService<User> _userRepo { get; set; }

        public ContactsViewModel(IDataService<User> userRepo)
        {
            _userRepo = userRepo;
            
        }
    }
}

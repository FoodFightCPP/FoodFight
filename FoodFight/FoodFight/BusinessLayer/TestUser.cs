using FoodFight.Domain.Models;
using FoodFight.ViewModels;

namespace FoodFight.BusinessLayer
{
    public class TestUser : BaseViewModel
    {
        public TestUser()
        {
            User peter = new User()
            {
                Id = 1,
                UserName = "PeterSteele111",
                Name = "Peter Steele",
                Address = "6847 Cram Road",
                City = "Williamsburg",
                State = "Michigan",
                Zip = 49690,
                Country = "United States",
                Email = "petersteele111@gmail.com",
                Phone = "231-357-1970",
                Gender = "Male",
                Bio = "I am a father of 2 and a husband to my beautiful wife. I love all things tech and really enjoy going on hikes and hunting.",
                Facebook = "https://www.facebook.com/peterbsteele",
                Twitter = "",
                Instagram = "",
                Website = "https://www.pbsteele.com",
                Password = "1234Test4321",
                ProfilePic = "https://google.com"
            };
        }
    }
}
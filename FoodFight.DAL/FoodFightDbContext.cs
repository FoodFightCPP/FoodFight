using FoodFight.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodFight.DAL
{
    public class FoodFightDbContext : DbContext
    {
        // Independent Tables
        public DbSet<User> Users { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Setting> Settings { get; set; }

        // Join Tables - Users
        public DbSet<ConnectedUser> ConnectedUsers { get; set; }
        public DbSet<BlockedUser> BlockedUsers { get; set; }
        public DbSet<UserSetting> UserSettings { get; set; }

        // Join Tables - Restaurants
        public DbSet<FavoriteRestaurant> FavoriteRestaurants { get; set; }
        public DbSet<BlockedRestaurant> BlockedRestaurants { get; set; }

        // Session Tables
        public DbSet<Session> Sessions { get; set; }
        public DbSet<SwipeList> SwipeLists { get; set; }

        public DbSet<RejectedRestaurant> RejectedRestaurants { get; set; }
        public DbSet<AcceptedRestaurant> AcceptedRestaurants { get; set; }

        public DbSet<MatchedRestaurant> MatchedRestaurants { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=sharedcloud1.squidix.net;database=pbswebde_foodfight;user=pbswebde_ffAdmin;password=ThisIsAAnnoyingPassword");
        }
    }
}

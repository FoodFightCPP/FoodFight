using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodFight.DAL
{
    public class FFDbContext : DbContext
    {
        public DBContext(DbContextOptions options) : base(options)
        {

        }
    }
}

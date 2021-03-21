using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodFight.DAL
{
    public class DbContextFactory : IDesignTimeDbContextFactory<FoodFightDbContext>
    {
        public FoodFightDbContext CreateDbContext(string[] args = null)
        {

            var options = new DbContextOptionsBuilder<FoodFightDbContext>();
            options.UseSqlServer("Server=tcp:cppfoodfightdb.database.windows.net,1433;Database=FoodFight;User ID=cppff;Password=Capstone1;Encrypt=True;TrustServerCertificate=True;");

            return new FoodFightDbContext(options.Options);
        }
    }
}

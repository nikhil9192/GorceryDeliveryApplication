namespace FoodDeliveryDAL.Migrations
{
    using FoodDeliveryDAL.Repository;
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FoodDeliveryDAL.Data.FoodDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FoodDeliveryDAL.Data.FoodDbContext context)
        {
            Admin newadmin = new Admin
            {
                Email = "Shashant1@gmial.com",
                UserName = "shashant1234",
                FirstName = "shashant",
                LastName = "chaudhary",
                PhoneNumber = "8896477007",
                RoleId = 1
            };
            var passwordHash = new PasswordHasher<Admin>();
            newadmin.Password = passwordHash.HashPassword(newadmin, "Admin@123");
            context.Admins.Add(newadmin);
           context.SaveChanges();

        }
    }
}

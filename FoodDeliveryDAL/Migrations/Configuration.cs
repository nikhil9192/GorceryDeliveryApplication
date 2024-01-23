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
            // Check if the Roles table is empty
            if (!context.Roles.Any())
            {
                // Add roles to the Role table
                context.Roles.AddOrUpdate(
                    r => r.Name,
                    new Role { Name = "Admin" },
                    new Role { Name = "Customer" }
                // Add more roles as needed
                );
                context.SaveChanges();
            }

            // Check if the Admins table is empty
            if (!context.Admins.Any())
            {
                Admin newadmin = new Admin
                {
                    Email = "Shashant1@gmail.com", // Fix the typo in the email address
                    UserName = "shashant1234",
                    FirstName = "shashant",
                    LastName = "chaudhary",
                    PhoneNumber = "8896477007",
                    RoleId = 1 // Assuming the admin role has RoleId = 1
                };

                var passwordHash = new PasswordHasher<Admin>();
                newadmin.Password = passwordHash.HashPassword(newadmin, "Admin@123");

                context.Admins.AddOrUpdate(newadmin);
                context.SaveChanges();
            }

            base.Seed(context);
        }


    }
}

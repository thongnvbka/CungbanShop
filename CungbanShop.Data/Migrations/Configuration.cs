namespace CungbanShop.Data.Migrations
{
    using CungbanShop.Model.Models;
    using Microsoft.AspNet.Identity;
    
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CungbanShop.Data.CungbanShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CungbanShop.Data.CungbanShopDbContext context)
        {
            //    //  This method will be called after migrating to the latest version.

            //    var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new CungbanShopDbContext()));

            //    var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new CungbanShopDbContext()));

            //    var user = new ApplicationUser()
            //    {
            //        UserName = "thongnv",
            //        Email = "thongnv.bka@gmail.com",
            //        EmailConfirmed = true,
            //        BirthDay = DateTime.Now,
            //        FullName = "Nguyen van thong"

            //    };

            //    manager.Create(user, "123654$");

            //    if (!roleManager.Roles.Any())
            //    {
            //        roleManager.Create(new IdentityRole { Name = "Admin" });
            //        roleManager.Create(new IdentityRole { Name = "User" });
            //    }

            //    var adminUser = manager.FindByEmail("thongnv.bka@gmail.com");

            //    manager.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });
        }
    }   }


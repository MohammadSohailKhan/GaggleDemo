namespace MdSohail_GaggleChallenge.Migrations.Identity
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    //using Microsoft.AspNet.Identity;
    //using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MdSohail_GaggleChallenge.Models.ApplicationDbContext>
    {

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\Identity";
        }

        protected override void Seed(ApplicationDbContext context)
        {
            var roleManager = new RoleManger<IdentityRole>(new
            RoleStore<IdentityRole>(context));

            if (!RoleManager.RoleExists("Admin"))
                roleManger.Create(new IdentityRole("Admin"));

            if (!roleManger.RoleExists("Guest"))
            roleManger.Create(new IdentityRole("Guest"));

            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            //String[] emails = { "a@a.a", "g@g.g" };

            if (UserManager.FindByEmail("a@a.a") == null)
            {
                var user = new ApplicationUser
                {
                    Email = "a@a.a",
                    UserName = "a@a.a",
                };
                var result = UserManager.Create(user, "P@$$w0rd");
                if (result.Succeeded)
                {
                    UserManager.AddToRole(UserManager.FindByEmail(user.Email).Id, "admin");
                }


            }

            if (UserManager.FindByEmail("g@g.g") == null)
            {
                var user = new ApplicationUser
                {
                    Email = "g@g.g",
                    UserName = "g@g.g",
                };
                var result = UserManager.Create(user, "P@$$w0rd");
                if (result.Succeeded)
                    UserManager.AddToRole(UserManager.FindByEmail(user.Email).Id, "Guest");
            }
        }
    }
}
  

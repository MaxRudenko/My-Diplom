using Diplom.Domain;
using Diplom.Domain.Enums;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "Diplom.Data.ApplicationDbContext";
        }

        protected override void Seed(ApplicationDbContext context)
        {
            AddRoles(context);
            AddAdministrator(context);
            base.Seed(context);
        }
        private void AddAdministrator(ApplicationDbContext context)
        {
            var adminCount = context.Users.Any(x => x.Email == "admin@admin.com");
            if (!adminCount)
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "admin@admin.com", Email = "admin@admin.com", CreationDate = DateTime.Now, EmailConfirmed=true };
                manager.Create(user, "qwe123");
                manager.AddToRole(user.Id, UserRoles.Admin);
            }
            context.SaveChanges();
        }
        private void AddRoles(ApplicationDbContext context)
        {
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            if (!roleManager.Roles.Any())
            {
                roleManager.Create(new IdentityRole { Name = UserRoles.TeamAdmin });
                roleManager.Create(new IdentityRole { Name = UserRoles.User });
                roleManager.Create(new IdentityRole { Name = UserRoles.Admin });
            }
            context.SaveChanges();
        }
    }
}

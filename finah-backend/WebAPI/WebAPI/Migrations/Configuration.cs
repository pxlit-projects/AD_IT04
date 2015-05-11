namespace WebAPI.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebAPI.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebAPI.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(WebAPI.Models.ApplicationDbContext context)
        {
            if (!context.Roles.Any(r => r.Name == "Admin"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Admin" };

                manager.Create(role);
            }

            if (!context.Users.Any(u => u.UserName == "admin@gmail.com"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "admin@gmail.com", Email = "admin@gmail.com" };

                manager.Create(user, "P@ssw0rd");
                manager.AddToRole(user.Id, "Admin");
            }

            if (!context.Roles.Any(r => r.Name == "Dokter"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Dokter" };

                manager.Create(role);
            }

            if (!context.Users.Any(u => u.UserName == "dokter@gmail.com"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "dokter@gmail.com", Email = "dokter@gmail.com" };

                manager.Create(user, "P@ssw0rd");
                manager.AddToRole(user.Id, "Dokter");
            }

            if (!context.Roles.Any(r => r.Name == "Onderzoeker"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Onderzoeker" };

                manager.Create(role);
            }

            if (!context.Users.Any(u => u.UserName == "onderzoeker@gmail.com"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "onderzoeker@gmail.com", Email = "onderzoeker@gmail.com" };

                manager.Create(user, "P@ssw0rd");
                manager.AddToRole(user.Id, "Onderzoeker");
            }

            if (!context.Roles.Any(r => r.Name == "PatientMantelzorger"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "PatientMantelzorger" };

                manager.Create(role);
            }          
        }
    }
}

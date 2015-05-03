using System;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;


namespace UAVdb.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {

    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        private static bool _created = false;
        
        public ApplicationDbContext(IHostingEnvironment env)
        {            
            // Create the database and schema if it doesn't exist
            // This is a temporary workaround to create database until Entity Framework database migrations 
            // are supported in ASP.NET 5
            if (!_created)
            {

                if (string.Equals(env.EnvironmentName, "Development", StringComparison.OrdinalIgnoreCase))
                {
                    var mono = Type.GetType("Mono.Runtime") != null;
                    if(!mono)
                    {
                        // TODO
                    }
                } else {
                    // need to add a way to test of Migrations are available
                    Database.AsRelational().ApplyMigrations();
                }

                _created = true;
            }
        }
        
        

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
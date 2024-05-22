using Corpa4Sem4.Database.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace PraktASPApp.Database
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User>? Users { get; set; }
        public DbSet<Message>? Messages { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
			var options = new
			{
				// Server = "89.169.1.120:5437",
				// Database = "asp",
				// User = "postgres",
				// Password = "Rudolf31",
                Server = "localhost",  // or your server IP
                Port = "5432",         // default port
                Database = "asp",
                User = "postgres",
                Password = ""     
			};

			// optionsBuilder.UseNpgsql($"Server = {options.Server}; Database ={options.Database}; Uid = {options.User}; Pwd = {options.Password};");
		            optionsBuilder.UseNpgsql($"Host={options.Server};Port={options.Port};Database={options.Database};Username={options.User}");

        }
    }
}

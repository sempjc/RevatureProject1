using App.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Linq;

namespace App.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // get the configuration file
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfiguration configuration = builder.Build();

            // Test if we are getting the connection string
            // Console.WriteLine(configuration.GetConnectionString("PizzaStoreAppDB"));

            // Passing connection string to DBContext
            var OptionsBuilder = new DbContextOptionsBuilder<PizzaStoreAppContext>();
            OptionsBuilder.UseSqlServer(configuration.GetConnectionString("PizzaStoreAppDB"));

            var options = OptionsBuilder.Options;
            var context = new PizzaStoreAppContext(options);
            var repo = new Repository(context);


            /*
             * 
             * Test Code on console
             * 
             */
            var customers = repo.GetAllCustomer();


            // Display the users available before adding one
            Console.WriteLine("List of customer before add one customer: ");
            foreach(var c in customers)
            {
                Console.WriteLine($"{c.FirstName} {c.LastName}");
            }
            Console.WriteLine("\n\n");


            // Ask User for information
            Console.WriteLine("Please Enter your Name:");
            //var name = "Abraham";
            // Console.WriteLine(name);
            var name = Console.ReadLine();

            Console.WriteLine("Please Enter your Last Name:");
            // var last = "Lincoln";
            // Console.WriteLine(last);
            var last = Console.ReadLine();
            Console.WriteLine("\n\n");

            Console.WriteLine(
                "Choose a location from List:\n" +
                "1. Reston \n" +
                "2. Vienna \n" +
                "3. Herndon \n"
                );
            // Console.WriteLine("You Choose Reston.");
            // var locationID = 1;
            var locationID = Console.ReadLine();
            int locId = Convert.ToInt32(locationID);


            // Add Customer
            repo.AddCustomer(name, last, locId);
            // Commit change to DB
            repo.SaveChange();
            Console.WriteLine("\n\n");


            // Display Customer table data after Customer creation
            Console.WriteLine("Update from Customer table: ");
            customers = repo.GetAllCustomer();
            foreach (var c in customers)
            {
                var location = repo.GetLocationByID(c.LocationId);
                Console.WriteLine($"{c.FirstName} {c.LastName}, {location.Name}\n");
            }
        }
    }
}
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
        }
    }
}
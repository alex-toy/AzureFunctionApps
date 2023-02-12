using Microsoft.Extensions.Configuration;
using System;

namespace AppConfigurationDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConfigurationBuilder builder = new ConfigurationBuilder();
            string azureConnectionString = Environment.GetEnvironmentVariable("ConnectionString");
            Console.WriteLine(azureConnectionString);

            builder.AddAzureAppConfiguration(azureConnectionString);
            IConfigurationRoot config = builder.Build();

            Console.WriteLine(config["TestApp:Settings:Message"] ?? "Hello world");
        }
    }
}

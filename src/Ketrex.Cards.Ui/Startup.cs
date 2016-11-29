
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using Microsoft.AspNetCore.Builder;

namespace Ketrex.Cards.Ui
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        private readonly IHostingEnvironment _hostingEnvironment;
        
        public Startup(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;

            var configurationBuilder = new ConfigurationBuilder()
            .SetBasePath(_hostingEnvironment.ContentRootPath)
            .AddJsonFile("appSettings.json")
            .AddJsonFile($"appSettings.{_hostingEnvironment.EnvironmentName}.json", optional: true);
            if (_hostingEnvironment.IsDevelopment())
            {
                Console.WriteLine("Environment: Development");
            }

            configurationBuilder.AddEnvironmentVariables();
            _configuration = configurationBuilder.Build();
        }

        public void Configure (IApplicationBuilder applicationBuilder, IHostingEnvironment hostingEnvironment)
        {
            if (hostingEnvironment.IsDevelopment()) 
            {
                applicationBuilder.UseDeveloperExceptionPage();
            }
            else
            {
                applicationBuilder.UseExceptionHandler("Error");
            }
            applicationBuilder.UseStaticFiles();
        }
    }
}
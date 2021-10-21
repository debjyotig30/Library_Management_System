using Library_Management_System.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Library_Management_System
{
    public class Startup
    {
        private IConfiguration _config;
        //Injecting IConfiguration service (constructor injection)
        //This is used to read the configuration from Configuration file, in this case, appsettings.
        public Startup(IConfiguration config)
        {
            _config = config;
        }



        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)//Dependency-Injection container
        {
            services.AddMvc().AddXmlSerializerFormatters();
            //services.AddMvcCore();
            services.AddSingleton<IUserRepository, MockUserRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                
            }

            app.UseStaticFiles(); //This serves all the static files.
            app.UseMvcWithDefaultRoute();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hosting environment: " + env.EnvironmentName);
            });
        }
    }
}

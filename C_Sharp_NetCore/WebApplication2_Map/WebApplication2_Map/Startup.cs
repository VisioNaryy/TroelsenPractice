using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace WebApplication2_Map
{
    public class Startup
    {
        
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Map("/home", home =>
            {
                home.Map("/index", (appBuilder) => // home/index
                {
                    appBuilder.Run(async (context) =>
                await context.Response.WriteAsync("<h2>Home Page </h2>"));

                });
                home.Map("/about", About);
            });
            
            //Map
            //app.Map("/index", (appBuilder) => 
            //{
            //    appBuilder.Run(async (context) =>
            //await context.Response.WriteAsync("<h2>Home Page </h2>"));

            //app.Map("/about", (appBuilder) =>
            //{
            //    appBuilder.Run(async (context) =>
            //    await context.Response.WriteAsync("<h2>About Page </h2>"));

            //});
            //app.Map("/about", About);

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("<h2>Not found!</h2>");

            });
            
        }
        
        
        private static void About(IApplicationBuilder app)
        {
            
            app.Run(async(context)=> await context.Response.WriteAsync("<h2>About</h2>"));
        }

        
    }
}

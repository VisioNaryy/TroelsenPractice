using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace WebApplication2_Run_Use
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        //public delegate Task RequestDelegate(HttpContext context)
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            int x = 5;
            int y = 2;
            int z = 0;
            //Используем метод Use, который наследуется от делегата RequestDelegate(HttpContext context)
            app.Use(async (context, next) =>
            {
                //await context.Response.WriteAsync("Hello, Use method!");
                z = x * y; //z=10
                await next();
                z = z * 5; //z=100
                await context.Response.WriteAsync($"z = {z}");
            });
            //в ответ на запрос пользователя он будет отправлять строку "Hello, Use method!"



            app.Run(async (context) =>
            {
                //await context.Response.WriteAsync($"z = {z}");
                z = z * 2; //20
                await Task.FromResult(0);
            });
            app.UseStaticFiles();

            app.Run(Handle);
        }

        private async Task Handle (HttpContext context)
        {
            string host = context.Request.Host.Value;
            string path = context.Request.Path;
            string query = context.Request.QueryString.Value;

            context.Response.ContentType = "text/html; charset=utf-8";

            await context.Response.WriteAsync($"<h3>Хост: {host}</h3>" +
                $"<h3>Путь запроса: {path}</h3>" +
                $"<h3>Параметр запроса: {query}</h3>"

                );

        }
    }
}

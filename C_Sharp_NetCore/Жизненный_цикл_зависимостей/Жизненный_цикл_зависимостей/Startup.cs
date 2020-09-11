using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Жизненный_цикл_зависимостей.Services;

namespace Жизненный_цикл_зависимостей
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //первый способ
            //services.AddTransient<ICounter, RandomCounter>();
            //services.AddTransient<CounterService>();

            //второй способ
            //services.AddScoped<ICounter, RandomCounter>();
            //services.AddScoped<CounterService>();

            //третий способ
            services.AddSingleton<ICounter, RandomCounter>();
            services.AddSingleton<CounterService>();

            //Или к примеру у нас есть зависимость IMessageSender
            //и есть две ее реализации - EmailMessageSender и SmsMessageSender:
            //services.AddTransient<IMessageSender>(provider => {

            //    if (DateTime.Now.Hour >= 12) return new EmailMessageSender();
            //    else return new SmsMessageSender();
            //});
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMiddleware<CounterMiddleware>();
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});
        }
    }
}

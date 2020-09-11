using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection_ConfigureServices.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection_ConfigureServices
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IMessageSender, SmsMessageSender>();
            services.AddTransient<TimeService>();
            services.AddTransient<MessageService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.

        //Подключаем все сервисы, которые мы сами определили
        //public void Configure(IApplicationBuilder app, IMessageSender sender, TimeService timeserv)

        public void Configure(IApplicationBuilder app)
        {
            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}


            //app.Run(async (context) =>
            //{
            //    MessageService sender =
            //    context.RequestServices.GetService<MessageService>();

            //    await context.Response.WriteAsync($"{sender?.SendMessage()}");
            //});

            app.UseMiddleware<MessageMiddleware>();
        }
    }
}

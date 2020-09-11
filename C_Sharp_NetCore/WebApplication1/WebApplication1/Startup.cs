using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace WebApplication1
{
    public class Startup
    {
        string name;
        public Startup()
        {
            name = "Valentine";
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            int x = 2;
            // если приложение в процессе разработки
            if (env.IsDevelopment())
            {
                // то выводим информацию об ошибке, при наличии ошибки
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // установка обработчика ошибок
                app.UseExceptionHandler("/Home/Error");
            }

            //app.UseStaticFiles();
            //app.Use
            //app.Map
            //app.MapWhen
            //app.UseWhen
            //app.Run
            //app.UseMiddleware


            // обработка запроса - получаем констекст запроса в виде объекта context
            app.Run(async (context) =>
            {
                x *= 2;
                // отправка ответа в виде строки "Hello World!"
                await context.Response.WriteAsync($"Hello {name} {x}");
            });
        }
    }
}

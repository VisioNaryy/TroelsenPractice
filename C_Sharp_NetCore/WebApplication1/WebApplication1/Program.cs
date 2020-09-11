using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

using Microsoft.AspNetCore.Http; 




namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var host = WebHost.Start("https://localhost:8080",
                context => context.Response.WriteAsync("Hello Webhost!")))
            {
                Console.WriteLine("App has been started!");
                host.WaitForShutdown();
            }



            //CreateWebHostBuilder(args).Build().Run();
            //var host = new WebHostBuilder()
            //    .UseKestrel()//IIS сервер будет перенаправлять запрос на Kestrel, a Kestrel - приложению
            //    .UseContentRoot(Directory.GetCurrentDirectory()) //настраиваем корневой каталог приложения
            //    .UseIISIntegration()//вначале запрос будет идти на IIS сервер, который выступает в роли
            //                        //прокси сервера
            //    .UseStartup<Startup>() // устанавливаем главный файл приложения
            //    .Build(); // создаем хост
            //    host.Run(); //запускаем приложение

        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}

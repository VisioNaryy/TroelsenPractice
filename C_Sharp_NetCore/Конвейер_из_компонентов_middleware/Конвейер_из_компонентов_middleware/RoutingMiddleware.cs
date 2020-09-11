using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Конвейер_из_компонентов_middleware
{
    public class RoutingMiddleware
    {
        RequestDelegate _next;
        public RoutingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        //обработка запроса
        //http://localhost:****/index?token=12345
        // /index - в данном случае это путь запроса
        //и его нам надо получить
        public async Task InvokeAsync(HttpContext context)
        {
            string path = context.Request.Path.Value.ToLower();
            if (path == "/" || path == "/index")
                await context.Response.WriteAsync("Home page");
            else if (path == "/about")
                await context.Response.WriteAsync("About");
            else context.Response.StatusCode = 404;


        }



    }
}

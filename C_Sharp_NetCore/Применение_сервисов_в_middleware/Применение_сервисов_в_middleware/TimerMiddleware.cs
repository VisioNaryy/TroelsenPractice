using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Применение_сервисов_в_middleware.Services;

namespace Применение_сервисов_в_middleware
{
    public class TimerMiddleware
    {
        private readonly RequestDelegate _next;
        
        public TimerMiddleware(RequestDelegate next)
        {
            _next = next;
            
        }

        public async Task InvokeAsync(HttpContext context, TimeService timeService)
        {
            if (context.Request.Path.Value.ToLower()== "/time")
            {
                context.Response.ContentType = "text/html; charset=utf-8";
                //Также можно получать сервисы серез свойство HttpContext.RequestServices в тех ситуациях, 
                //когда необходимость использования сервисов может зависеть от среды выполнения:
                //TimeService timeService = context.RequestServices.GetService<TimeService>();

                await context.Response.WriteAsync($"Current time is: {timeService?.Time}");
            }
            else
            {
                await _next.Invoke(context);
            }

        }
    }
}

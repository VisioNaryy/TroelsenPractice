using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Жизненный_цикл_зависимостей.Services;

namespace Жизненный_цикл_зависимостей
{
    public class CounterMiddleware
    {
        private readonly RequestDelegate _next;
        private int i = 0;
        public CounterMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, ICounter counter, CounterService counterService)
        {
            i++;
            context.Response.ContentType = "text/html, charset=utf-8";
            await context.Response.WriteAsync($"Request {i}; Counter: {counter.Value}; Service:{counterService.Counter.Value}");
        }
    }
}

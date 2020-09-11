using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Конвейер_из_компонентов_middleware
{
    public class ErrorHandlingMiddleware
    {
        RequestDelegate _next;
        public ErrorHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            await _next(context);
            if (context.Response.StatusCode == 403)
                await context.Response.WriteAsync("Access Denied");
            else if (context.Response.StatusCode == 404)
                await context.Response.WriteAsync("Not Found");
        }

    }
}

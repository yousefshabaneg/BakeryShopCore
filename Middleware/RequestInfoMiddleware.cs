using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class RequestInfoMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public RequestInfoMiddleware(RequestDelegate next, ILoggerFactory logfac)
        {
            _next = next;
            _logger = logfac.CreateLogger<RequestInfoMiddleware>();
        }

        public async Task Invoke(HttpContext httpContext)
        {
            _logger.LogInformation("** Handling Request : " + httpContext.Request.Path + " **");
            await _next(httpContext);
            _logger.LogInformation("** Finished The Request **");
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class RequestInfoMiddlewareExtensions
    {
        public static IApplicationBuilder UseRequestInfoMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RequestInfoMiddleware>();
        }
    }
}

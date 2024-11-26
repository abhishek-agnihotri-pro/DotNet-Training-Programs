using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;


namespace MVCactionResult.Middleware
{
    public class SampleMiddleware
    {
        private readonly RequestDelegate _next;
        public SampleMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            await context.Response.WriteAsync("\n THis is request handler in sample middleware \n");
            _next.Invoke(context);
            await context.Response.WriteAsync("\n This is Response Handler in sample middleware \n");
        }
    }

    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseSample(this IApplicationBuilder app)
        {
            return app.UseMiddleware<SampleMiddleware>();
        }
    }
}
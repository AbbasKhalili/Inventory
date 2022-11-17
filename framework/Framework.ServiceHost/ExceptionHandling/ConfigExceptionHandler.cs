using System.Resources;
using Microsoft.AspNetCore.Builder;

namespace Framework.ServiceHost.ExceptionHandling
{
    public static class ConfigExceptionHandler
    {
        public static void ConfigExceptionMiddleware(this IApplicationBuilder app, ResourceManager resource)
        {
            ExceptionMiddleware.ResourceManager = resource;
            app.UseMiddleware<ExceptionMiddleware>();
        }
    }
}

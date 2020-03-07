using LearnMiddlewares.Middlewares.Implementations;
using Microsoft.AspNetCore.Builder;

namespace LearnMiddlewares.Middlewares
{
    public static class MiddlewareExtension
    {
        public static IApplicationBuilder UseSampleMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LogMiddleware>();
        }
    }
}

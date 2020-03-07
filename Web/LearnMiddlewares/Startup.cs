using LearnMiddlewares.Middlewares;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Configuration;

namespace LearnMiddlewares
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            LoggerFactory.Create(builder => builder.AddConsole());

            app.UseSampleMiddleware();

            #region Run , request terminal middleware, executed and never pass request to next middleware

            app.Run(async (HttpContext context) =>
            {
                await context.Response.WriteAsync("Test");
            });

            app.Run(async (HttpContext context) =>
            {
                await context.Response.WriteAsync("Test1");
            });

            #endregion

            #region link to mentioned middleware based to request path

            // simple matching
            app.Map("/test", HandleMap);

            // complex matching
            app.MapWhen(
                delegate (HttpContext context)
                {
                    return context.Request.Query.ContainsKey("username");
                }, HandleMapWhen);

            #endregion

            #region Use , process request, response and or pass request to next middleware

            app.Use(async (context, next) =>
            {
                //await next();
                await context.Response.WriteAsync("I am cutting");
            });

            #endregion

            #region built in middlewares / exists on nuget

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World first");
                });

                endpoints.MapGet("/test", async context =>
                {
                    await context.Response.WriteAsync("Hello World second");
                });
            });

            #endregion
        }

        #region private handlers

        private static void HandleMap(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync("Sample Route");
                
            });
        }

        private static void HandleMapWhen(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync("Map when Route");
            });
        }

        #endregion
    }
}

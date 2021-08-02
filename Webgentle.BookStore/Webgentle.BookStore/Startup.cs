using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webgentle.BookStore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.Use(async(context, next)=>
            //{
            //    await context.Response.WriteAsync("Hello my First middlewear!");
            //    await next();
            //    await context.Response.WriteAsync("Hello my First middlewear response!");
            //});

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello my Second middlewear!");
            //    await next();
            //    await context.Response.WriteAsync("Hello my Second middlewear response!");
            //});

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello my Third middlewear!");
            //    await next();
            //});


            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();

               /* endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
/*
                            
                       // For environment variable check       
                    if (env.IsDevelopment())
                    {
                        await context.Response.WriteAsync("Hello developer!");
                    }
                    else if (env.IsEnvironment("Develop"))
                    {
                        await context.Response.WriteAsync("Hello Custome Name!");
                    }
                    else if (env.IsProduction())
                    {
                        await context.Response.WriteAsync("Hello PRO!");
                    }
                    else if (env.IsStaging())
                    {
                        await context.Response.WriteAsync("Hello Stage!");
                    }
                    else
                    await context.Response.WriteAsync(env.EnvironmentName); 
                
                    
                    }); */
            });

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.Map("/ar", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello ar!");
            //    });
            //});
        }
    }
}

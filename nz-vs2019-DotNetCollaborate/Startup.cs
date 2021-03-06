using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nz_vs2019_DotNetCollaborate
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("<h1>Hello World!<h1>");
                    await context.Response.WriteAsync("<br>Welcome to my site.");
                    await context.Response.WriteAsync("<br>Asp.NET Core 3.1 Tutorial");
                    await context.Response.WriteAsync("<br>Introduction to .NET Core 3.1");
                    await context.Response.WriteAsync("<br>Garbage Collection");
                    await context.Response.WriteAsync("<br>.NET Data types");
                });
            });
        }
    }
}

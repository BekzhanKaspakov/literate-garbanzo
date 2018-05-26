using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace WebApp2
{
    public class Startup
    {
		string name;
		public Startup()
		{
			name = "Bekzhan";
		}
		// This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env){
        
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
			app.UseStaticFiles();
			app.Map("/index", (appBuilder) =>
			{
				appBuilder.Run(async (context) =>
				{
					await context.Response.WriteAsync($"<html>");
					name = context.Request.Host.Value;
					await context.Response.WriteAsync($"<h3>Hello: {name}</h3>");
					name = context.Request.Protocol;
					await context.Response.WriteAsync($"<h3>Protocol: {name}</h3>");
					int? asd = context.Request.Host.Port;
					await context.Response.WriteAsync($"<h3>Port: {asd}</h3>");
					name = context.Request.ContentType;
					await context.Response.WriteAsync($"<h3>Content Type: {name}</h3>\n");
					//name = context.Request.HttpContext.Request.Body;
					await context.Response.WriteAsync($"<h3>SHIT: {name}</h3>");
					await context.Response.WriteAsync($"</html>");

				});
                
			});
            app.Run(async (context) =>
            {
				await context.Response.WriteAsync($"<html>");
				name = context.Request.Host.Value;
				await context.Response.WriteAsync($"<h3>Hello: {name}</h3>");
				name = context.Request.Protocol;
				await context.Response.WriteAsync($"<h3>Protocol: {name}</h3>");
				int? asd = context.Request.Host.Port;
				await context.Response.WriteAsync($"<h3>Port: {asd}</h3>");
				name = context.Request.ContentType;
				await context.Response.WriteAsync($"<h3>Content Type: {name}</h3>");
				await context.Response.WriteAsync($"</html>");

            });
        }
    }
}

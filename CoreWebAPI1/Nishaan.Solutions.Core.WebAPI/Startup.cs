using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nishaan.Solutions.Core.WebAPI.App_Start;

namespace Nishaan.Solutions.Core.WebAPI
{
    public class Startup
    {
        private IConfiguration _configuration;
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services,IConfiguration configuration)
        {
            _configuration = configuration;
            DependencyInjectionConfig.AddScope(services);

            JwtTokenConfig.AddAuthentication(services, configuration);

            DBContextConfig.Initialize(services, configuration);

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IServiceProvider svp)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});

            DBContextConfig.Initialize(_configuration, env, svp);

            app.UseCors(builder => builder

                .AllowAnyOrigin()

                .AllowAnyMethod()

                .AllowAnyHeader()

                .AllowCredentials());

            app.UseAuthentication();

            app.UseMvc();
        }
    }
}

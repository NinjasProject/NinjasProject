using APIFlixNinjas.Data;
using Lamar.Microsoft.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace APIFlixNinjas
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddControllers();
            services.AddLamar(new ApplicationRegistry());
            services.AddSwaggerGen(swag =>
            {
                swag.SwaggerDoc("v0", new OpenApiInfo { Title = "APIFlixNinjas Service", Version = "v0" });
                var basePath = AppContext.BaseDirectory;
                var xmlPath = Path.Combine(basePath, "APIFlixNinjas.xml");
                swag.IncludeXmlComments(xmlPath);
                swag.DescribeAllEnumsAsStrings();
                swag.DescribeAllParametersInCamelCase();
                swag.CustomSchemaIds(i => i.FullName);
            });
            services.AddDbContext<APIFlixNinjasDbContext>(options => options.UseSqlServer(Configuration["database:connection"], b => b.MigrationsAssembly("APIFlixNinjas")));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseSwagger();
            app.UseSwaggerUI(x => x.SwaggerEndpoint("v0/swagger.json", "APIFlixNinjas Service"));
        }
    }
}

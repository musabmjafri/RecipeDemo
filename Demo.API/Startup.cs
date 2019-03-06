using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Demo.API.Extension;
using Demo.API.Mappings;
using Demo.Core.DbContext;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;

namespace Demo.API
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
            services.AddDbContext<FMTContext>(options =>
                options.UseSqlServer(this.Configuration.GetConnectionString("DefaultConnection"))
            );

            AddDependencies(services);

            services.AddApiVersioning();
            var mvcBuilder = services.AddMvc(opt =>
            {
                opt.UseCentralRoutePrefix(new RouteAttribute("api/v{version:apiVersion}"));
            });

            mvcBuilder.SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            AddSwagger(services);

            services.AddSingleton(provider => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutoMapperMappingProfile());
            }).CreateMapper());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // app.UseHttpsRedirection();
            app.UseMvc();

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("../swagger/v1/swagger.json", "Demo Application");
            });
        }

        private void AddDependencies(IServiceCollection services)
        {
            var dependencyInjection = new DependencyInjection();
            dependencyInjection.Map(services, Configuration);
        }

        private void AddSwagger(IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "IU Security and Safety",
                    Description = "IU Security and Safety  Web API",
                    TermsOfService = "None",

                });
                c.AddSecurityDefinition("Bearer", new ApiKeyScheme { In = "header", Description = "Please enter JWT with Bearer into field", Name = "Authorization", Type = "apiKey" });
                c.AddSecurityRequirement(new Dictionary<string, IEnumerable<string>> {
                { "Bearer", Enumerable.Empty<string>() },
                 });
            });
        }
    }

    public static class MvcOptionsExtensions
    {
        public static void UseCentralRoutePrefix(this MvcOptions opts, IRouteTemplateProvider routeAttribute)
        {
            opts.Conventions.Insert(0, new RouteConvention(routeAttribute));
        }
    }
}

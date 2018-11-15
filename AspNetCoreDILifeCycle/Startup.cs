using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreDILifeCycle.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetCoreDILifeCycle
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
            // Sample 1
            services.AddSingleton<MyFatherService>();
            services.AddSingleton<MyMotherService>();
            services.AddSingleton<MyChildService>();

            //// Sample 2
            //services.AddScoped<MyFatherService>();
            //services.AddScoped<MyMotherService>();
            //services.AddScoped<MyChildService>();

            //// Sample 3
            //services.AddTransient<MyFatherService>();
            //services.AddTransient<MyMotherService>();
            //services.AddTransient<MyChildService>();

            //// Sample 4
            //services.AddSingleton<MyFatherService>();
            //services.AddSingleton<MyMotherService>();
            //services.AddScoped<MyChildService>();

            //// Sample 5
            //services.AddSingleton<MyFatherService>();
            //services.AddSingleton<MyMotherService>();
            //services.AddTransient<MyChildService>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseMvc();
        }
    }
}

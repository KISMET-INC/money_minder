
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using money_minder.Models;

namespace money_minder
{
    public class Startup
    {     
        //===================================//
        // STARTUP CONSTRUCTOR
        //===================================//
        public Startup(IConfiguration configuration) { 
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        //===================================//
        // CONFIGURATION SERVICES
        //===================================//
        public void ConfigureServices(IServiceCollection services)
        {   
            //ADDED SERVICES
            services.AddDbContext<MyContext>(options => options.UseMySql (Configuration["DBInfo:ConnectionString"]));
            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddSession();
        }

        //===================================//
        // CONFIGURE
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        //===================================//
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // ADDED TOOLS
            app.UseStaticFiles();
            app.UseMvc();
            app.UseSession();

        }
    }
}



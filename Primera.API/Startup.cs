using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using Premiera.Services.ServiceInterfaces;
using Premiera.Services.Services;
using Premiera.Data.Data;
using Microsoft.EntityFrameworkCore;
using Premiera.Repositories.Extensions;
using Premiera.Services.Extensions;
using Primera.API.Middlware;

namespace Primera.API
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

            // Registration of Custom Services
            services.AddCustomServices();


            // Registration of Repositories
            services.AddRepositories();


            //Adding Data(Db) Context
            services.AddDbContext<ApplicationDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("MainDBConnection")));


            //Automapper Config
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddControllers();

            //Custom Swagger config
            services.AddSwagger();
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

            //Adding middlware custom swagger
            app.UseCustomSwagger();


           
        }
    }
}

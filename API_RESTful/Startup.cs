using API_RESTful.Business;
using API_RESTful.Business.Implementation;
using API_RESTful.Model;
using API_RESTful.Model.MyContext;
using API_RESTful.Repository;
using API_RESTful.Repository.Implementation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_RESTful
{
    public class Startup
    {
        public IWebHostEnvironment Environment { get; }

        public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            Configuration = configuration;
            Environment  = environment;

            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();

        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddApiVersioning();

            var connection = Configuration["MySQLConnection:MySQLConnectionString"];

            if (Environment.IsDevelopment())
            {
                MigrateDatabase(connection);
            }

            services.AddDbContext<MySQLContext>(options => options.UseMySql(connection));

            services.AddScoped<IPersonbusiness, PersonBusiness>();

            services.AddScoped<IGenericRepository<Person>, GenericRepository<Person>>();
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
        }

        private void MigrateDatabase(string connection)
        {
            try
            {
                var envolveConection = new MySql.Data.MySqlClient.MySqlConnection(connection);
                var evolve = new Evolve.Evolve(envolveConection, msg => Log.Information(msg))
                {
                    Locations = new List<string> { "db/migrations", "db/dataset" },
                    IsEraseDisabled = true,
                };

                evolve.Migrate();
            }
            catch (Exception ex)
            {

                Log.Error("Database migration failed", ex);
                throw;
            }
        }
    }
}

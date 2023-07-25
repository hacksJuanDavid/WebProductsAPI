using WEBAPI.Context;
using Microsoft.EntityFrameworkCore;
using WEBAPI.Tests;

namespace WEBAPI.Controllers
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            // Add the conexion to the database
            services.AddDbContext<ContextAplication>(options =>
                options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")));

            // Add the controllers
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            // Add the routing
            app.UseRouting();

            // Add task and category using the class Test
            /*using (var scope = app.ApplicationServices.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<ContextAplication>();

                // Insertar tareas
                Test.InsertTask(context);

                // Insertar categorías
                Test.InsertCategory(context);
            }
            */

            app.UseEndpoints(endpoints =>
            {
                // Add the endpoint to the database
                endpoints.MapGet("/Startup", context => context.Response.WriteAsync("Conexion Exitosa a la Base de Datos"));
                // Add the controllers
                endpoints.MapControllers();
            });
        }
    }
}

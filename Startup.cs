using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OrderReceiverSystem.Interfaces;
using OrderReceiverSystem.Modelos.Services;

namespace OrderReceiverSystem
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // MVC
            services.AddControllersWithViews();
            
            // Servicios propios
            services.Add(new ServiceDescriptor(typeof(ILog), new LogSystem())); // singleton
            services.AddTransient(typeof(ILocation), typeof(OrderLocation)); //Transient
            services.AddScoped(typeof(IDepartment), typeof(DepartmentStockAvailability)); // Scoped
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();
         //   app.UseEndpoints(endpoints =>
         //   {
         //       endpoints.MapGet("/", async context =>
         //       {
         //           await context.Response.WriteAsync("Hello World!");
         //       });
         //   });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=ExampleLog}/{action=Index}/");
            });
        }
    }
}

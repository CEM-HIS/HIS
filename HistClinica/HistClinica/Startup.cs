using HistClinica.Data;
using HistClinica.Interfaces;
using HistClinica.Repositories;
using HistClinica.Repositories.Interfaces;
using HistClinica.Repositories.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace HistClinica
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
            services.AddSession();
            services.AddRazorPages()
           .AddRazorRuntimeCompilation();
            services.AddControllersWithViews();
            services.AddTransient<ICronogramaRepository, CronogramaRepository>();
            services.AddTransient<IPacienteRepository, PacienteRepository>();
            services.AddTransient<IPersonaRepository, PersonaRepository>();
            services.AddTransient<IUtilRepository, UtilRepository>();
            services.AddTransient<IMedicoRepository, MedicoRepository>();
            services.AddTransient<IEmpleadoRepository, EmpleadoRepository>();
            services.AddTransient<ICitaRepository, CitaRepository>();
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();
            services.AddTransient<ICajaRepository,CajaRepository>();
            services.AddTransient<IDetalleRepository, DetalleRepository>();
            services.AddTransient<IGeneralRepository, GeneralRepository>();
            IServiceCollection serviceCollection =
                services.AddDbContext<ClinicaServiceContext>(options => options.UseSqlServer(Configuration["Connection:ClinicaServiceConnection"]));
            services.AddCors(opciones =>
            {
                opciones.AddPolicy("AllowMyOrigin",
                constructor => constructor.AllowAnyOrigin().AllowAnyHeader());
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseSession();
            app.UseRouting();

          //  app.UseSession();

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Login}/{action=Index}");
            });
            app.UseCors("AllowMyOrigin");
        }
    }
}
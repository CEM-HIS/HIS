using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Clinica2._0.Repositories.EntityRepositories.Repositories;
using Clinica2._0.Repositories.Repositories;
using Clinica2._0.Repositories.EntityRepositories.Interfaces;
using Clinica2._0.Models;
using HistClinica.Repositories.EntityRepositories.Repositories;
using Clinica2._0.Data;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace Clinica2._0
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
            services.AddRazorPages().AddRazorRuntimeCompilation();
            services.AddControllersWithViews();
            services.AddTransient<ICronogramaRepository, CronogramaRepository>();
            services.AddTransient<IPacienteRepository, PacienteRepository>();
            services.AddTransient<IPersonaRepository, PersonaRepository>();
            services.AddTransient<IUtilRepository, UtilRepository>();
            services.AddTransient<IMedicoRepository, MedicoRepository>();
            services.AddTransient<IEmpleadoRepository, EmpleadoRepository>();
            services.AddTransient<ICitaRepository, CitaRepository>();
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();
            services.AddTransient<ICajaRepository, CajaRepository>();
            services.AddTransient<IDetalleRepository, DetalleRepository>();
            services.AddTransient<IGeneralRepository, GeneralRepository>();
            services.AddTransient<ILicenciaRepository, LicenciaRepository>();
            services.AddDbContext<ClinicaServiceContext>(options => options.UseSqlServer(Configuration["Connection:ClinicaServiceConnection"]));
            services.AddDefaultIdentity<USUARIO>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<ClinicaServiceContext>();
            services.AddRazorPages();
            services.AddCors(opciones =>
            {
                opciones.AddPolicy("AllowMyOrigin",
                constructor => constructor.AllowAnyOrigin().AllowAnyHeader());
            });
            services.ConfigureApplicationCookie(options => options.LoginPath = "/login");
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Login}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using SeminarskiWebAPI.Database;
using SeminarskiWebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using SeminarskiWebAPI.Services.Interfaces;
using SeminarskiWebAPI.Services.Services;
using SeminarskiWebAPI.Security;
using SeminarskiWebAPI.Filters;
using Microsoft.EntityFrameworkCore;
using SeminarskiWebAPI.Database;

namespace SeminarskiAPI
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
            services.AddMvc(x => x.Filters.Add<ErrorFilter>()).SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddAutoMapper(typeof(Startup));


            services.AddSwaggerGen();
            //services.AddAuthentication("BasicAuthentication")
            //   .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);
            var connection = @"Server=HP-250-G4\MSSQLSERVER_OLAP;Database=Seminarski_RSII_170025;Trusted_Connection=True;ConnectRetryCount=0";
            //var connection = Configuration.GetConnectionString("eAutobus");
            services.AddDbContext<eAutobusi>(options => options.UseSqlServer(connection));

            services.AddScoped<IKupacService, KupacService>();
            services.AddScoped<IAutobusService, AutobusService>();
            services.AddScoped<IAutobusVozacService, AutobusVozacService>();
            services.AddScoped<ICjenovnikService, CjenovnikService>();
            services.AddScoped<IGradService, GradService>();
            services.AddScoped<IKartaService, KartaService>();
            services.AddScoped<IRasporedVoznjeService, RasporedVoznjeService>();
            services.AddScoped<IStanicaService, StanicaService>();
            services.AddScoped<ITipKarteService, TipKarteService>();
            services.AddScoped<IVozacService, VozacService>();
            services.AddScoped<IVrstaKarteService, VrstaKarteService>();
            services.AddScoped<IZonaService, ZonaService>();
            services.AddScoped<IAutobusService, AutobusService>();
            services.AddScoped<IGarazaService, GarazaService>();
            services.AddScoped<IUlogeService, UlogeService>();
            services.AddScoped<IKorisnikService, KorisnikService>();
            services.AddScoped<ILoginService, LoginService>();
            services.AddScoped<IKartaKupacService, KartaKupacService>();
            services.AddScoped<IRecenzijaService, RecenzijaService>();
            services.AddScoped<IPlatiOnlineService, PlatiOnlineService>();

            //services.AddScoped<IService<TModel,TSearch>,BaseService<TModel,TSearch,TDatabase>>();
            services.AddAuthentication("BasicAuthentication")
                .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication",null);




            services.AddSwaggerGen();
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseSwagger(c =>
            {
                c.SerializeAsV2 = true;
            });
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                
            });
            app.UseDeveloperExceptionPage();
            //app.UseHttpsRedirection();
            app.UseAuthentication();
            
            app.UseMvc();
        }


    }
}

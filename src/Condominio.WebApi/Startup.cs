using AutoMapper;
using Condominio.Aplication.Interfaces;
using Condominio.Aplication.Services;
using Condominio.Domain.Interfaces;
using Condominio.Infra.data.ConfigurationDb;
using Condominio.Infra.data.Contexto;
using Condominio.Infra.data.Repositorio;
using Condominio.Infra.IOC;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;

namespace Condominio.WebApi
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
            //autoMapper
            services.AddAutoMapper(typeof(Startup));
            // injeção de dependencias
            //DependenceInjections.Injectable(services);
            //MediatR

            //service
            services.AddScoped<IUsuarioService, UsuarioService>();

            //repositório
            //services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IReservaRepository, ReservaRepository>();
            services.AddScoped<IOrdemDeServicoRepository, OrdemDeServicoRepository>();
            services.AddScoped<IOcorrenciaRepository, OcorrenciaRepository>();
            services.AddScoped<IDespesaRepository, DespesaRepository>();
            services.AddScoped<ICondominioRepository, CondominiosRepository>();
            services.AddScoped<IAvisosRepository, AvisoRepository>();

            services.AddMediatR(typeof(Startup));
            //Mongo
            services.Configure<ConfigurationDb>(Configuration.GetSection(nameof(ConfigurationDb)));
            services.AddSingleton<IConfigurationDb>( option => option.GetRequiredService<IOptions<ConfigurationDb>>().Value);
            services.AddSingleton<DbContext>();


            services.AddControllers();

            services.AddMvc();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("api", new OpenApiInfo
                {
                    Version ="1.0",
                    Title = "Condominio",
                    Description = "Api para gerencia de condomínio",
                    

                });
            });

            
        }

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

            app.UseSwagger();

            app.UseSwaggerUI(c => {

                c.SwaggerEndpoint("/swagger/api/swagger.json", "My API V1");
            });
        }
    }
}

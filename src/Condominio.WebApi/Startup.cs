using AutoMapper;
using Condominio.Aplication.AutoMappers;
using Condominio.Aplication.Interfaces;
using Condominio.Aplication.Services;
using Condominio.Domain.Commands;
using Condominio.Domain.Commands.Usuario;
using Condominio.Domain.Interfaces;
using Condominio.Infra.data.ConfigurationDb;
using Condominio.Infra.data.Contexto;
using Condominio.Infra.data.Repositorio;
using Condominio.Infra.IOC;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Text;

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
            

            // injeção de dependencias
            //DependenceInjections.Injectable(services);
            

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
            //MediatR
            var assembly = AppDomain.CurrentDomain.Load("Condominio.Domain");
            services.AddMediatR(typeof(Startup));
            services.AddScoped<IRequestHandler<AlterarUsuarioCommand, RetornoCommands>, UsuarioCommandHandler>();
            services.AddScoped<IRequestHandler<AvaliarUsuarioCommad, RetornoCommands>, UsuarioCommandHandler>();
            services.AddScoped<IRequestHandler<CriarUsuarioCommand, RetornoCommands>, UsuarioCommandHandler>();
            services.AddScoped<IRequestHandler<DeletarUsuarioCommand, RetornoCommands>, UsuarioCommandHandler>();
            //Mongo
            services.Configure<ConfigurationDb>(Configuration.GetSection(nameof(ConfigurationDb)));
            services.AddSingleton<IConfigurationDb>( option => option.GetRequiredService<IOptions<ConfigurationDb>>().Value);
            services.AddSingleton<DbContext>();

            services.AddCors();
            services.AddControllers();
            //mapper
            var configMap = new MapperConfiguration(cfs => {
                cfs.AddProfile(new DomainToViewModelMapper());
                cfs.AddProfile(new ViewModelToDomainMapper());            
            });

            IMapper mapper = configMap.CreateMapper();
            services.AddSingleton(mapper);

            services.AddMvc();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("api", new OpenApiInfo
                {
                    Version ="1.0",
                    Title = "Condominio",
                    Description = "Api para gerencia de condomínio",
                });

                c.AddSecurityDefinition(
                    "Bearer",
                    new OpenApiSecurityScheme
                    {
                        In = ParameterLocation.Header,
                        Description = "Autenticação baseada em JWT token.",
                        Name = "Authorization",
                        Type = SecuritySchemeType.ApiKey
                    }
                        
                );

                c.AddSecurityRequirement( new OpenApiSecurityRequirement
                {
                  {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Id = "Bearer",
                            Type = ReferenceType.SecurityScheme
                        }
                    },new List<string>()
                  }
                });
            });

            //jwt
            var Key = Encoding.ASCII.GetBytes("@$WWEOISD(*)*&#¨&¨@#&@");
            services.AddAuthentication(x => {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

            }).AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
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

            app.UseCors( x => 
                x.AllowAnyOrigin()
                 .AllowAnyMethod()
                 .AllowAnyHeader()               
            );

            app.UseAuthentication();
            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();

            app.UseSwaggerUI(c => {

                c.SwaggerEndpoint("/swagger/api/swagger.json", "CONDOMÍNIO - API V1");
            });
        }
    }
}

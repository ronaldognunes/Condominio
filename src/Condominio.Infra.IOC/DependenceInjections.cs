using Condominio.Aplication.Interfaces;
using Condominio.Aplication.Services;
using Condominio.Domain.Interfaces;
using Condominio.Infra.data.Repositorio;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Condominio.Infra.IOC
{
    public class DependenceInjections
    {
        public static void Injectable(IServiceCollection service)
        {
            //service
            service.AddScoped<IUsuarioService, UsuarioService>();

            //repositório
            service.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            service.AddScoped<IUsuarioRepository, UsuarioRepository>();
            service.AddScoped<IReservaRepository, ReservaRepository>();
            service.AddScoped<IOrdemDeServicoRepository, OrdemDeServicoRepository>();
            service.AddScoped<IOcorrenciaRepository, OcorrenciaRepository>();
            service.AddScoped<IDespesaRepository, DespesaRepository>();
            service.AddScoped<ICondominioRepository, CondominiosRepository>();
            service.AddScoped<IAvisosRepository,AvisoRepository>();

            //


            
        }
    }
}

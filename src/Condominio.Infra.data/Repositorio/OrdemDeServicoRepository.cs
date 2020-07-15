using Condominio.Domain.Entidades;
using Condominio.Domain.Interfaces;
using Condominio.Infra.data.Contexto;

namespace Condominio.Infra.data.Repositorio
{
    public class OrdemDeServicoRepository:Repository<OrdemDeServico>,IOrdemDeServico
    {
        public OrdemDeServicoRepository(DbContext context) :base(context)
        {
            
        }
    }
}
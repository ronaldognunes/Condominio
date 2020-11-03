using Condominio.Domain.Entidades;
using Condominio.Domain.Interfaces;
using Condominio.Infra.data.Contexto;

namespace Condominio.Infra.data.Repositorio
{
    public class DespesaRepository:Repository<Despesas>, IDespesaRepository
    {
        public DespesaRepository(DbContext context) :base(context)
        {
            
        }
    }
}
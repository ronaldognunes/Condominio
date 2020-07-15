using Condominio.Domain.Entidades;
using Condominio.Domain.Interfaces;
using Condominio.Infra.data.Contexto;

namespace Condominio.Infra.data.Repositorio
{
    public class CondominiosRepository:Repository<Condominios>,ICondominio
    {
        public CondominiosRepository(DbContext context) :base(context)
        {
            
        }
    }
}
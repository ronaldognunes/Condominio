using Condominio.Domain.Entidades;
using Condominio.Domain.Interfaces;
using Condominio.Infra.data.Contexto;

namespace Condominio.Infra.data.Repositorio
{
    public class AvisoRepository : Repository<Avisos>, IAvisos
    {
        public AvisoRepository(DbContext context) :base(context)
        {
            
        }
    }
}
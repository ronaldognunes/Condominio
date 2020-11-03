using Condominio.Domain.Entidades;
using Condominio.Domain.Interfaces;
using Condominio.Infra.data.Contexto;

namespace Condominio.Infra.data.Repositorio
{
    public class ReservaRepository:Repository<Reservas>,IReservaRepository
    {
        public ReservaRepository(DbContext context) :base(context)
        {
            
        }
    }
}
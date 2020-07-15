using Condominio.Domain.Entidades;
using Condominio.Domain.Interfaces;
using Condominio.Infra.data.Contexto;

namespace Condominio.Infra.data.Repositorio
{
    public class OcorrenciaRepository:Repository<Ocorrencia>, IOcorrencia
    {
        public OcorrenciaRepository(DbContext context) :base(context)
        {
            
        }
    }
}
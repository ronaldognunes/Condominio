using Condominio.Domain.Entidades;
using Condominio.Domain.Interfaces;
using Condominio.Infra.data.Contexto;

namespace Condominio.Infra.data.Repositorio
{
    public class UsuarioRepository:Repository<Usuario>,IUsuario
    {
        public UsuarioRepository(DbContext context) :base(context)
        {
            
        }
    }
}
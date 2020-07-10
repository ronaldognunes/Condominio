using Condominio.Domain.Entidades;
using Condominio.Domain.Interfaces;

namespace Condominio.Infra.data
{
    public class UsuarioRepository:Repository<Usuario>,IUsuario
    {
        
    }
}
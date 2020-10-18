using Condominio.Domain.Entidades;
using Condominio.Domain.objetosDeValor;
using System.Threading.Tasks;

namespace Condominio.Domain.Interfaces
{
    public interface IUsuarioRepository:IRepository<Usuarios>
    {
        Task<Usuarios> login(LoginUsuario login);
    }
}
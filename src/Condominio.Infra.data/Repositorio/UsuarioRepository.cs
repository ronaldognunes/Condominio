using Condominio.Domain.Entidades;
using Condominio.Domain.Interfaces;
using Condominio.Domain.objetosDeValor;
using Condominio.Infra.data.Contexto;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace Condominio.Infra.data.Repositorio
{
    public class UsuarioRepository:Repository<Usuarios>,IUsuarioRepository
    {
        public UsuarioRepository(DbContext context) :base(context)
        {
            
        }
        public async Task<Usuarios> login(LoginUsuario login)
        {
            return await db.FindAsync<Usuarios>( u => u.Login.Email == login.Email && u.Login.Senha == login.Senha).Result.FirstOrDefaultAsync();
        }
    }
}
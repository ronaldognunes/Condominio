using System.Threading.Tasks;
using Condominio.Aplication.ViewModels;
using Condominio.Domain.Commands.Usuario;

namespace Condominio.Aplication.Interfaces
{
    public interface IUsuarioService
    {
         Task registrar(CriarUsuarioCommand usuario);
         Task atualizar(AlterarUsuarioCommand usuario);
         Task apagar(DeletarUsuarioCommand usuario);
         Task logar (LoginViewModel usuario);

    }
}
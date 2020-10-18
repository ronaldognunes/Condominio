using System.Collections.Generic;
using System.Threading.Tasks;
using Condominio.Aplication.ViewModels;
using Condominio.Domain.Commands.Usuario;

namespace Condominio.Aplication.Interfaces
{
    public interface IUsuarioService
    {
        Task<RetornoViewModel> RegistrarAsync(UsuarioViewModel usuario);
        Task<RetornoViewModel> AtualizarAsync(UsuarioViewModel usuario);
        Task<RetornoViewModel> ApagarAsync(string id);
        Task<UsuarioViewModel> LogarAsync(LoginViewModel login);
        Task<IList<UsuarioViewModel>> RetornarUsuariosAsync();
        Task<UsuarioViewModel> ConsultarUsuario(string id);
        Task<RetornoViewModel> AvaliarUsuario(SituacaoUsuarioViewModel usuario);

    }
}
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
        Task<UsuarioViewModel> LogarAsync(string usuario);
        Task<IList<UsuarioViewModel>> RetornarUsuariosAsync();            

    }
}
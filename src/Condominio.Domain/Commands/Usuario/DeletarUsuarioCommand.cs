using MediatR;

namespace Condominio.Domain.Commands.Usuario
{
    public class DeletarUsuarioCommand :UsuarioCommand, IRequest<RetornoCommands>
    {
        public DeletarUsuarioCommand(string idUsuario)
        {
            this.idUsuario = idUsuario;
        }
    }
}
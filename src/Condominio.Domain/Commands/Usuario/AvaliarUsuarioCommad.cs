using Condominio.Domain.objetosDeValor.Enums;
using MediatR;

namespace Condominio.Domain.Commands.Usuario
{
    public class AvaliarUsuarioCommad : UsuarioCommand, IRequest<RetornoCommands>
    {        
       public AvaliarUsuarioCommad(string id, string situacao)
       {
           this.idUsuario = id;
           this.situacao = situacao;
       }        
    }
}
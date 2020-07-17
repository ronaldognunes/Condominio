using Condominio.Domain.objetosDeValor.Enums;

namespace Condominio.Domain.Commands.Usuario
{
    public class AvaliarUsuarioCommad
    {
        public int idUsuario { get; set; }
        public ESituacaoUsuario situacao { get; set; }         
    }
}
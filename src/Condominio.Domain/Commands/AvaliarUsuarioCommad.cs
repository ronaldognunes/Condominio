using Condominio.Domain.objetosDeValor.Enums;

namespace Condominio.Domain.Commands
{
    public class AvaliarUsuarioCommad
    {
        public int idUsuario { get; set; }
        public ESituacaoUsuario MyProperty { get; set; }         
    }
}
using System;

namespace Condominio.Domain.Commands
{
    public class AlterarUsuarioCommand : CriarUsuarioCommand
    {
        public int idUsuario { get; set; }
    }
}
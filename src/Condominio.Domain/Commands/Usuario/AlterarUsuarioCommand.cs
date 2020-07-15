using System;

namespace Condominio.Domain.Commands.Usuario
{
    public class AlterarUsuarioCommand : CriarUsuarioCommand
    {
        public int idUsuario { get; set; }
    }
}
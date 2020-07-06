using System;

namespace Condominio.Domain.Commands
{
    public class CriarUsuarioCommand
    {
        public string Nome { get;  set; }
        public int NumCasa { get;  set; }
        public DateTime dataNascimento { get;  set; }
        public int telefone { get;  set; }
        public string perfil { get;  set; }
        public string senha { get;  set; }
        public string email { get;  set; }
        
    }
}
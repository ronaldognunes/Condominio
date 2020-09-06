using System;
using System.Collections.Generic;
using Flunt.Notifications;
using Flunt.Validations;

namespace Condominio.Domain.Commands.Usuario
{
    public class UsuarioCommand :Notifiable 
    {
        public string idUsuario { get; set; }
        public string Nome { get;  set; }
        public int NumCasa { get;  set; }
        public DateTime dataNascimento { get;  set; }
        public int telefone { get;  set; }
        public string perfil { get;  set; }
        public string senha { get;  set; }
        public string email { get;  set; }
        public string situacao { get; set; }         

        public void ValidaAlterarUsuario(){
            AddNotifications( new Contract().Requires().IsNull(idUsuario,"idUsuario","Usuario é obrigatório"));             
        }
    }
}
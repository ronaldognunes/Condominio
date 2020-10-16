using System;
using System.Collections.Generic;
using Flunt.Notifications;
using Flunt.Validations;

namespace Condominio.Domain.Commands.Usuario
{
    public class UsuarioCommand :Notifiable 
    {
        public string Id { get; set; }
        public string Nome { get;  set; }
        public int NumCasa { get;  set; }
        public DateTime DataNascimento { get;  set; }
        public int Telefone { get;  set; }
        public string Perfil { get;  set; }
        public string Senha { get;  set; }
        public string Email { get;  set; }
        public string Situacao { get; set; }         

        public void ValidaAlterarUsuario(){
            AddNotifications( new Contract().Requires().IsNull(Id,"idUsuario","Usuario é obrigatório"));             
        }
    }
}
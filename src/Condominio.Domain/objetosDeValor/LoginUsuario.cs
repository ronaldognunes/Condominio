using Condominio.Domain.Core.ObjetosDeValor;
using Flunt.Validations;

namespace Condominio.Domain.objetosDeValor
{
    public class LoginUsuario:ObjetoDeValor
    {
        public LoginUsuario(string perfil, string senha, Email email)
        {
            this.Perfil = perfil;
            this.Senha = senha;
            this.Email = email;
                        
            AddNotifications(email, new Contract().Requires().HasMinLen(senha,6,"senha","Senha deve possui no mínimo 6 dígitos."));

        }
        public string Perfil { get; private set; }
        public string Senha { get; private set; }
        public Email Email { get; private set; }

    }
}
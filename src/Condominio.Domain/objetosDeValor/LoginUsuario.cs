using Condominio.Domain.Core.ObjetosDeValor;
using Flunt.Validations;

namespace Condominio.Domain.objetosDeValor
{
    public class LoginUsuario:ObjetoDeValor
    {
        public LoginUsuario(string perfil, string senha, Email email)
        {
            this.perfil = perfil;
            this.senha = senha;
            this.email = email;
                        
            AddNotifications(email, new Contract().HasMinLen(senha,6,"senha","Senha deve possui no mínimo 6 dígitos."));

        }
        public string perfil { get; private set; }
        public string senha { get; private set; }
        public Email email { get; private set; }

    }
}
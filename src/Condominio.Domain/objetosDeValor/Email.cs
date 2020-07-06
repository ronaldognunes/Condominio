
using Condominio.Domain.Core.ObjetosDeValor;
using Flunt.Validations;

namespace Condominio.Domain.objetosDeValor
{
    public class Email : ObjetoDeValor
    {
        public Email(string edEmail)
        {
            this.edEmail = edEmail;
            AddNotifications(new Contract().IsEmailOrEmpty(edEmail,"edEmail","Obrigatório informar e-mail valido"));
        }
        public string edEmail { get; set; }
    }
}
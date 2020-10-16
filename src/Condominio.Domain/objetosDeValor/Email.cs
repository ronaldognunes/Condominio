
using Condominio.Domain.Core.ObjetosDeValor;
using Flunt.Validations;

namespace Condominio.Domain.objetosDeValor
{
    public class Email : ObjetoDeValor
    {
        public Email(string edEmail)
        {
            this.EdEmail = edEmail;
            AddNotifications(new Contract().Requires().IsEmailOrEmpty(edEmail,"edEmail","Obrigatório informar e-mail valido"));
        }
        public string EdEmail { get; set; }
    }
}
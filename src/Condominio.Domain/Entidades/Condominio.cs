using Condominio.Domain.Core.Entidades;
using Condominio.Domain.objetosDeValor;
using Flunt.Validations;

namespace Condominio.Domain.Entidades
{
    public class Condominio:Entidade
    {
        public Condominio(string nome, Endereco endereco)
        {
            this.nome = nome;
            this.endereco = endereco;
            AddNotifications(endereco,
            new Contract().IsNotNullOrEmpty(nome,"nome","Nome do condomínio não informado."));
        }

        public string nome { get; private set; }
        
        public Endereco endereco { get; private set; }
    }
}
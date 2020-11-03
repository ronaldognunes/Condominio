using Condominio.Domain.Core.ObjetosDeValor;
using Flunt.Validations;

namespace Condominio.Domain.objetosDeValor
{
    public class Fornecedor:ObjetoDeValor
    {
        public Fornecedor(string nome, string telefone, string cpf, string cnpj)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.cpf = cpf;
            this.cnpj = cnpj;
            AddNotifications(new Contract().Requires().IsNotNullOrEmpty(nome,"nome","Nome do fornecedor não informado.")
            .IsNotNull(telefone,"telefone","telefone não informado"));
        }

        public string nome { get; private set; }
        public string telefone { get; private set; }
        public string cpf { get; private set; }
        public string cnpj { get; private set; }
    }
}
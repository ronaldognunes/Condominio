using Condominio.Domain.Core.Entidades;
using Condominio.Domain.objetosDeValor;

namespace Condominio.Domain.Entidades
{
    public class Despesas : Entidade
    {
        public Despesas(string nome, decimal valTotal, string descricao, Fornecedor fornecedor)
        {
            this.nome = nome;
            this.valTotal = valTotal;
            this.descricao = descricao;
            Fornecedor = fornecedor;
            AddNotifications(fornecedor);
        }

        public string nome { get; private set; }
        public decimal valTotal { get; private set; }
        public string descricao { get; private set; }
        public Fornecedor Fornecedor { get; private set; }

    }
}
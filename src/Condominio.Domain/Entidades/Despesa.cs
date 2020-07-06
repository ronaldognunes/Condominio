using Condominio.Domain.Core.Entidades;

namespace Condominio.Domain.Entidades
{
    public class Despesa :Entidade
    {
        public int qtd { get; private set; }
        public string nome { get; private set; }
        public decimal valor { get; private set; }
        public decimal valTotal { get; private set; }
        public string descricao { get; private set; }
        public string Fornecedor { get; private set; }

    }
}
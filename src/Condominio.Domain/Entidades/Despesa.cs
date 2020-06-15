namespace Condominio.Domain.Entidades
{
    public class Despesa :Base
    {
        public int qtd { get; set; }
        public string nome { get; set; }
        public decimal valor { get; set; }
        public decimal valTotal { get; set; }
        public string descricao { get; set; }
        public string Fornecedor { get; set; }

    }
}
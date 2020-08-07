namespace Condominio.Aplication.ViewModels
{
    public class DespesaViewModel
    {
        public string nome { get; private set; }
        public decimal valTotal { get; private set; }
        public string descricao { get; private set; }
        public FornecedorViewModel Fornecedor { get; private set; }
    }
}
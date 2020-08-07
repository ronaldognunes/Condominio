namespace Condominio.Aplication.ViewModels
{
    public class OrdemServicoViewModel
    {
        public string nomeServico { get; private set; }
        public string descricao { get; private set; }
        public int tipoGarantia { get; private set; }
        public int periodo { get; private set; }
        public decimal valorServico { get; private set; }
        public PrestadorServicoViewModel prestador { get; private set; }
    }
}
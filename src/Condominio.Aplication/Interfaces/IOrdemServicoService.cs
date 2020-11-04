using Condominio.Aplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Aplication.Interfaces
{
    public interface IOrdemServicoService
    {
        Task<RetornoViewModel> IncluirOcorrencia(OrdemServicoViewModel ordemServico);
        Task<RetornoViewModel> ExcluirOcorrencia(string id);
        Task<RetornoViewModel> AlterarOcorrencia(OrdemServicoViewModel ordemServico);
        Task<OrdemServicoViewModel> ExibirOcorrencia(string id);
        Task<IList<OrdemServicoViewModel>> ExibirTodasOcorrencia();
    }
}

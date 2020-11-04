using Condominio.Aplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Aplication.Interfaces
{
    public interface IOcorrenciasService
    {
        Task<RetornoViewModel> IncluirOcorrencia(OcorrenciaViewModel ocorrencia);
        Task<RetornoViewModel> ExcluirOcorrencia(string id);
        Task<RetornoViewModel> AlterarOcorrencia(OcorrenciaViewModel ocorrencia);
        Task<OcorrenciaViewModel> ExibirOcorrencia(string id);
        Task<IList<OcorrenciaViewModel>> ExibirTodasOcorrencia();
    }
}

using Condominio.Aplication.Interfaces;
using Condominio.Aplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Aplication.Services
{
    public class OcorrenciaService : IOcorrenciasService
    {
        public Task<RetornoViewModel> AlterarOcorrencia(OcorrenciaViewModel ocorrencia)
        {
            throw new NotImplementedException();
        }

        public Task<RetornoViewModel> ExcluirOcorrencia(string id)
        {
            throw new NotImplementedException();
        }

        public Task<OcorrenciaViewModel> ExibirOcorrencia(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<OcorrenciaViewModel>> ExibirTodasOcorrencia()
        {
            throw new NotImplementedException();
        }

        public Task<RetornoViewModel> IncluirOcorrencia(OcorrenciaViewModel ocorrencia)
        {
            throw new NotImplementedException();
        }
    }
}

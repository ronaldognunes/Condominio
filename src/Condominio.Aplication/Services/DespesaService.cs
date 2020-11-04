using Condominio.Aplication.Interfaces;
using Condominio.Aplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Aplication.Services
{
    public class DespesaService : IDespesaService
    {
        public Task<RetornoViewModel> AlterarDespesa(DespesaViewModel despesa)
        {
            throw new NotImplementedException();
        }

        public Task<RetornoViewModel> ExcluirDespesa(string id)
        {
            throw new NotImplementedException();
        }

        public Task<DespesaViewModel> ExibirDespesa(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<DespesaViewModel>> ExibirTodasDespesas()
        {
            throw new NotImplementedException();
        }

        public Task<RetornoViewModel> IncluirDespesa(DespesaViewModel despesa)
        {
            throw new NotImplementedException();
        }
    }
}

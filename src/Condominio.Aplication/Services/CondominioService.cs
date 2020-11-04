using Condominio.Aplication.Interfaces;
using Condominio.Aplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Aplication.Services
{
    public class CondominioService : ICondominioService
    {
        public Task<RetornoViewModel> AlterarCondominio(CondominioViewModel condominio)
        {
            throw new NotImplementedException();
        }

        public Task<RetornoViewModel> ExcluirCondominio(string id)
        {
            throw new NotImplementedException();
        }

        public Task<CondominioViewModel> ExibirCondominio(string id)
        {
            throw new NotImplementedException();
        }

        public Task<RetornoViewModel> IncluirCondominio(CondominioViewModel condominio)
        {
            throw new NotImplementedException();
        }
    }
}

using Condominio.Aplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Aplication.Interfaces
{
    public interface ICondominioService
    {
        Task<RetornoViewModel> IncluirCondominio(CondominioViewModel condominio);
        Task<RetornoViewModel> ExcluirCondominio(string id);
        Task<RetornoViewModel> AlterarCondominio(CondominioViewModel condominio);
        Task<CondominioViewModel> ExibirCondominio(string id);
    }
}

using Condominio.Aplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Aplication.Interfaces
{
    public interface IDespesaService
    {
        Task<RetornoViewModel> IncluirDespesa(DespesaViewModel despesa);
        Task<RetornoViewModel> ExcluirDespesa(string id);
        Task<RetornoViewModel> AlterarDespesa(DespesaViewModel despesa);
        Task<DespesaViewModel> ExibirDespesa(string id);
        Task<IList<DespesaViewModel>> ExibirTodasDespesas();
        
    }
}

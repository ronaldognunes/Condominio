using Condominio.Aplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Aplication.Interfaces
{
    public interface IAvisoService
    {
        Task<RetornoViewModel> IncluirAvisos(AvisosViewModel aviso);
        Task<RetornoViewModel> ExcluirAviso(string id);
        Task<RetornoViewModel> AlterarAviso(AvisosViewModel aviso);
        Task<IList<AvisosViewModel>> ExibirTodosAviso();
        Task<AvisosViewModel> ConsultarAviso(string id);        
    }
}

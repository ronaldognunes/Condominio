using Condominio.Aplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Aplication.Interfaces
{
    public interface IReservaService
    {
        Task<RetornoViewModel> IncluirReserva(ReservaViewModel reserva);
        Task<RetornoViewModel> AlterarReserva(ReservaViewModel reserva);
        Task<RetornoViewModel> ExcluirReserva(string id);
        Task<ReservaViewModel> ExibirReserva(string id);

    }
}

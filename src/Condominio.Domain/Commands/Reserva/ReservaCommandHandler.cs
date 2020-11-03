using Condominio.Domain.Entidades;
using Condominio.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Condominio.Domain.Commands.Reserva
{
    public class ReservaCommandHandler :
        IRequestHandler<IncluirReservaCommand, RetornoCommands>,
        IRequestHandler<CancelarReservaCommand, RetornoCommands>
    {
        private readonly IReservaRepository _reservaRepository;
        public ReservaCommandHandler(IReservaRepository reservaRepository)
        {
            _reservaRepository = reservaRepository;
        }
        public async Task<RetornoCommands> Handle(IncluirReservaCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var reserva = new Reservas(request.dataAgendamento,request.nomeUsuario,request.idUsuario);
                await _reservaRepository.insert(reserva);
                return new RetornoCommands { mensagens = "Operação realizada com sucesso!" };
            }
            catch (Exception ex)
            {
                return new RetornoCommands { mensagens = ex.Message.ToString() };
            }
        }

        public async Task<RetornoCommands> Handle(CancelarReservaCommand request, CancellationToken cancellationToken)
        {
            try
            {                
                await _reservaRepository.delete(request.id);
                return new RetornoCommands { mensagens = "Operação realizada com sucesso!" };
            }
            catch (Exception ex)
            {
                return new RetornoCommands { mensagens = ex.Message.ToString() };
            }
        }
    }
}

using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Condominio.Domain.Commands.Reserva
{
    public class IncluirReservaCommand : ReservaCommand, IRequest<RetornoCommands>
    {
    }
}

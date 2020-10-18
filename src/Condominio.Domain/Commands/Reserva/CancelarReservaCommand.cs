using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Condominio.Domain.Commands.Reserva
{
    public class CancelarReservaCommand : ReservaCommand, IRequest<RetornoCommands>
    {
    }
}

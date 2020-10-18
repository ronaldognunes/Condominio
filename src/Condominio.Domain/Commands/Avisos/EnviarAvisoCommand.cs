using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Condominio.Domain.Commands.Avisos
{
    class EnviarAvisoCommand : AvisoCommand, IRequest<RetornoCommands>
    {
    }
}

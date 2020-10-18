using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Condominio.Domain.Commands.OrdemServico
{
    public class IncluirOrdemServicoCommand : OrdemServicoCommand, IRequest<RetornoCommands>
    {
    }
}

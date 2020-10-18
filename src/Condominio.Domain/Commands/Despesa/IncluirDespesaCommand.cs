using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Condominio.Domain.Commands.Despesa
{
    public class IncluirDespesaCommand : DespesaCommand, IRequest<RetornoCommands>
    {
    }
}

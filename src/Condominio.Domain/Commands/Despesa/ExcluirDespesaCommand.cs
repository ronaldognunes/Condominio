using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Condominio.Domain.Commands.Despesa
{
    public class ExcluirDespesaCommand : DespesaCommand, IRequest<RetornoCommands>
    {
    }
}

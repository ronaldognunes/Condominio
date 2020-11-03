using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Condominio.Domain.Commands.Condominio
{
    public class ExcluirCondominioCommand: CondominioCommand, IRequest<RetornoCommands>
    {
        public ExcluirCondominioCommand( string id)
        {
            this.id = id;
        }
    }
}

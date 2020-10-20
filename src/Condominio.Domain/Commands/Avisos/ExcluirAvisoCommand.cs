using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Condominio.Domain.Commands.Avisos
{
    public class ExcluirAvisoCommand : AvisoCommand, IRequest<RetornoCommands>
    {
        public ExcluirAvisoCommand( string id)
        {
            this.id = id;
        }
    }
}

using Condominio.Domain.objetosDeValor;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Condominio.Domain.Commands.Avisos
{
    public class EnviarAvisoCommand : AvisoCommand, IRequest<RetornoCommands>
    {
        public EnviarAvisoCommand(string id, List<Email> emails)
        {
            this.id =id;
            this.emails =emails;
        }
    }
}

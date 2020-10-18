using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Condominio.Domain.Commands.Ocorrencia
{
    public class AlterarOcorrenciaCommand: OcorrenciaCommand, IRequest<RetornoCommands>
    {
    }
}

﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Condominio.Domain.Commands.Condominio
{
    public class AlterarCondominioCommand : CondominioCommand, IRequest<RetornoCommands>
    {
    }
}

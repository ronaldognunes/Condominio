using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Condominio.Domain.Commands.Avisos
{
    public class IncluirAvisoCommand : AvisoCommand, IRequest<RetornoCommands>
    {
        public IncluirAvisoCommand(string descricao, string tipo,string situacao)
        {
            this.descricao = descricao;
            this.dataGeracao = DateTime.Now;
            this.tipo = tipo;
            this.situacao = situacao;
        }
    }
}

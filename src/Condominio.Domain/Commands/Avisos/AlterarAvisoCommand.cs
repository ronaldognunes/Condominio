using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Condominio.Domain.Commands.Avisos
{
    public class AlterarAvisoCommand : AvisoCommand, IRequest<RetornoCommands>
    {
        public AlterarAvisoCommand(string id, string situacao, string tipo,string descricao) {

            this.id = id;
            this.situacao = situacao;
            this.tipo = tipo;
            this.descricao = descricao;
        }
    }
}

using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Condominio.Domain.Commands.Condominio
{
    public class AlterarCondominioCommand : CondominioCommand, IRequest<RetornoCommands>
    {
        public AlterarCondominioCommand(string id, string nome, string referencia, string rua, string bairro, string cep, string cidade,string estado)
        {
            this.id = id;
            this.nome = nome;
            this.referencia = referencia;
            this.rua = rua;
            this.bairro = bairro;
            this.cep = cep;
            this.cidade = cidade;
            this.estado = estado;
        }
    }
}

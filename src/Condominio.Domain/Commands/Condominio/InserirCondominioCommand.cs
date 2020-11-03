using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Condominio.Domain.Commands.Condominio
{
    public class InserirCondominioCommand : CondominioCommand, IRequest<RetornoCommands>
    {
        public InserirCondominioCommand(string nome,string rua, string referencia, string bairro, string cep,string cidade, string estado)
        {
            this.nome = nome;
            this.rua = rua;
            this.referencia = referencia;
            this.bairro = bairro;
            this.cep = cep;
            this.cidade = cidade;
            this.estado = estado;
        }
    }
}

using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Condominio.Domain.Commands.Despesa
{
    public class AlterarDespesaCommand : DespesaCommand, IRequest<RetornoCommands>
    {
        public AlterarDespesaCommand(string id, string nome, string nomeFornecedor, string telefoneFornecedor, decimal valTotal,string cnpjFornecedor, string cpfFornecedor, string descricao)
        {
            this.id = id;
            this.nome = nome;
            this.nomeFornecedor = nomeFornecedor;
            this.telefoneFornecedor = telefoneFornecedor;
            this.valTotal = valTotal;
            this.cnpjFornecedor = cnpjFornecedor;
            this.cpfFornecedor = cpfFornecedor;
            this.descricao = descricao;
        }
    }
}

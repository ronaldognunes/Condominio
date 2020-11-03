using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Condominio.Domain.Commands.Despesa
{
    public class DespesaCommand
    {
        public string id { get; set; }
        public string nome { get; set; }
        public decimal valTotal { get; set; }
        public string descricao { get; set; }
        public string nomeFornecedor { get; set; }
        public string telefoneFornecedor { get; set; }
        public string cpfFornecedor { get; set; }
        public string cnpjFornecedor { get; set; }

    }
}

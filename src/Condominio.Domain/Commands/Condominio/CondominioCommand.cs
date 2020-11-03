using System;
using System.Collections.Generic;
using System.Text;

namespace Condominio.Domain.Commands.Condominio
{
    public class CondominioCommand
    {
        public string id { get; set; }
        public string nome { get; set; }
        public string rua { get;  set; }
        public string bairro { get;  set; }
        public string cidade { get;  set; }
        public string estado { get;  set; }
        public string cep { get;  set; }
        public string referencia { get;  set; }
    }
}

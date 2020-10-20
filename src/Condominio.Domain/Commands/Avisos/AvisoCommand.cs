using Condominio.Domain.objetosDeValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Condominio.Domain.Commands.Avisos
{
    public class AvisoCommand
    {
        public string id { get; set; }
        public string tipo { get;  set; }
        public string descricao { get;  set; }
        public string situacao { get;  set; }
        public DateTime dataGeracao { get;  set; }
        public IList<Email> emails { get; set; }
        public DateTime? dataEnvio { get;  set; }
        public IList<Documento> documentos { get; set; }
    }
}

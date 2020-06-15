using System;
using System.Collections.Generic;
using Condominio.Domain.objetosDeValor;

namespace Condominio.Domain.Entidades
{
    public class Avisos:Base
    {
        public string tipo { get; set; }
        public string descricao { get; set; }
        public string situacao{ get; set; }
        public DateTime dataGeracao { get; set; }
        public IList<Email> emails { get; set; }
        public DateTime? dataEnvio { get; set; }
        public IList<Documento> documentos { get; set; }
    }
}
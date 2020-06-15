using System;
using System.Collections.Generic;
using Condominio.Domain.objetosDeValor;

namespace Condominio.Domain.Entidades
{
    public class Ocorrencia : Base
    {
        public string descricao { get; set; }
        public string titulo { get; set; }
        public DateTime DataRegistro { get; set; }
        public DateTime DataOcorrencia { get; set; }
        public string situacao { get; set; }
        public IList<Documento> documentos { get; set; }
    }
}
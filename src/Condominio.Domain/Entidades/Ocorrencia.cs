using System;
using System.Collections.Generic;
using Condominio.Domain.Core.Entidades;
using Condominio.Domain.objetosDeValor;

namespace Condominio.Domain.Entidades
{
    public class Ocorrencia : Entidade
    {
        public string descricao { get; private set; }
        public string titulo { get; private set; }
        public DateTime DataRegistro { get; private set; }
        public DateTime DataOcorrencia { get; private set; }
        public string situacao { get; private set; }
        public IList<Documento> documentos { get; private set; }
    }
}
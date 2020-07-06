using System;
using System.Collections.Generic;
using Condominio.Domain.Core.Entidades;
using Condominio.Domain.objetosDeValor;

namespace Condominio.Domain.Entidades
{
    public class Avisos: Entidade
    {
        public string tipo { get; private set; }
        public string descricao { get; private set; }
        public string situacao{ get; private set; }
        public DateTime dataGeracao { get; private set; }
        public IList<Email> emails { get; private set; }
        public DateTime? dataEnvio { get; private set; }
        public IList<Documento> documentos { get; private set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using Condominio.Domain.Core.Entidades;
using Condominio.Domain.objetosDeValor;

namespace Condominio.Domain.Entidades
{
    public class Aviso: Entidade
    {
        public Aviso(string tipo, string descricao, string situacao, DateTime dataGeracao, DateTime? dataEnvio)
        {
            this.tipo = tipo;
            this.descricao = descricao;
            this.situacao = situacao;
            this.dataGeracao = dataGeracao;            
            this.dataEnvio = dataEnvio;   
            this._documentos = new List<Documento>();
            this._emails = new List<Email>();

        }

        public string tipo { get; private set; }
        public string descricao { get; private set; }
        public string situacao{ get; private set; }
        public DateTime dataGeracao { get; private set; }
        public IReadOnlyCollection<Email> emails { get {return _emails.ToArray();} }
        public DateTime? dataEnvio { get; private set; }
        public IReadOnlyCollection<Documento> documentos { get {return _documentos.ToArray();}  }
        

        private IList<Email> _emails;        
        private IList<Documento> _documentos;

        public void adicionarEmail( Email email){
            _emails.Add(email);
        }

        public void adcionarDocumento(Documento doc){
            _documentos.Add(doc);
        }
    }
}
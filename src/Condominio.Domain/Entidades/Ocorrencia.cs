using System;
using System.Collections.Generic;
using System.Linq;
using Condominio.Domain.Core.Entidades;
using Condominio.Domain.objetosDeValor;
using Condominio.Domain.objetosDeValor.Enums;
using Flunt.Validations;

namespace Condominio.Domain.Entidades
{
    public class Ocorrencia : Entidade
    {
        private IList<Documento> _documentos;
        public Ocorrencia(string descricao, string titulo,  DateTime dataOcorrencia, int idUsuario , string nome)
        {
            this.descricao = descricao;
            this.titulo = titulo;
            this.DataRegistro = DateTime.Now;
            this.DataOcorrencia =  dataOcorrencia;
            this.situacao = ESituacaoOcorrencia.aberta;
            this.idUsuario = idUsuario;
            this.Nome = nome;
            this._documentos = new List<Documento>();

            AddNotifications(new Contract().Requires()
                .IsNotNullOrEmpty(titulo,"titulo","Título não informado.")
                .IsNotNullOrEmpty(descricao,"descricao","Descrição não informada.")
                .IsNotNull(dataOcorrencia,"dataOcorrencia", "Data da ocorrência não informada")
            );
        }
        public int idUsuario { get; set; }
        public string Nome { get; set; }
        public string descricao { get; private set; }
        public string titulo { get; private set; }
        public DateTime DataRegistro { get; private set; }
        public DateTime DataOcorrencia { get; private set; }
        public ESituacaoOcorrencia situacao { get; private set; }
        public IReadOnlyCollection<Documento> documentos { get {return _documentos.ToArray();} }

        public void AdicionarDocumento(Documento doc){
            _documentos.Add(doc);
        }
    }
}
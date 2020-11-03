using System;
using Condominio.Domain.Core.Entidades;

namespace Condominio.Domain.Entidades
{
    public class Reservas : Entidade
    {
        public Reservas(DateTime dataAgendamento, string nomeUsuario, string idUsuario)
        {
            this.dataAgendamento = dataAgendamento;
            this.dataSolicitacao = DateTime.Now;
            this.nomeUsuario = nomeUsuario;
            this.idUsuario = idUsuario;
        }

        public DateTime dataAgendamento { get; private set; }
        public DateTime dataSolicitacao { get; private set; }
        public string nomeUsuario { get; private set; }
        public string idUsuario { get; private set; }
        
    }
}
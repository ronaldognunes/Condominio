using System;
using Condominio.Domain.Core.Entidades;

namespace Condominio.Domain.Entidades
{
    public class Reserva : Entidade
    {
        public Reserva(DateTime dataAgendamento, string nomeUsuario, int idUsuario)
        {
            this.dataAgendamento = dataAgendamento;
            this.dataSolicitacao = DateTime.Now;
            this.nomeUsuario = nomeUsuario;
            this.idUsuario = idUsuario;
        }

        public DateTime dataAgendamento { get; private set; }
        public DateTime dataSolicitacao { get; private set; }
        public string nomeUsuario { get; private set; }
        public int idUsuario { get; private set; }
        
    }
}
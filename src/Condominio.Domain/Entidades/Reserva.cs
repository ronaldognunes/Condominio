using System;
using Condominio.Domain.Core.Entidades;

namespace Condominio.Domain.Entidades
{
    public class Reserva : Entidade
    {
        public DateTime? dataAgendamento { get; private set; }
        public DateTime dataSolicitacao { get; private set; }
        
    }
}
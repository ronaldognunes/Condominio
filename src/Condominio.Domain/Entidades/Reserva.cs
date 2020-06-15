using System;

namespace Condominio.Domain.Entidades
{
    public class Reserva : Base
    {
        public DateTime? dataAgendamento { get; set; }
        public DateTime dataSolicitacao { get; set; }
        
    }
}
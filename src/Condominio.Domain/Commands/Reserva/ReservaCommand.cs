using System;
using System.Collections.Generic;
using System.Text;

namespace Condominio.Domain.Commands.Reserva
{
    public class ReservaCommand
    {
        public string id;
        public DateTime dataAgendamento { get; set; }
        public DateTime dataSolicitacao { get; set; }
        public string nomeUsuario { get; set; }
        public string idUsuario { get; set; }
    }
}

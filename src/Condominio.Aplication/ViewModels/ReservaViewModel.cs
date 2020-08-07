using System;

namespace Condominio.Aplication.ViewModels
{
    public class ReservaViewModel
    {
        public DateTime dataAgendamento { get; set; }
        public DateTime dataSolicitacao { get; set; }
        public string nomeUsuario { get; set; }
        public int idUsuario { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Condominio.Domain.Commands.Ocorrencia
{
    public class OcorrenciaCommand
    {
        public string id { get; set; }
        public string idUsuario { get; set; }
        public string nome { get; set; }
        public string descricao { get;  set; }
        public string titulo { get;  set; }
        public DateTime DataOcorrencia { get;  set; }
    }
}

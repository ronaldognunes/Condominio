using System;
using System.Collections.Generic;

namespace Condominio.Aplication.ViewModels
{
    public class AvisosViewModel
    {
        public string tipo { get; set; }
        public string descricao { get; set; }
        public string situacao{ get; set; }
        public DateTime dataGeracao { get; set; }
        public IList<string> emails { get; set; }
        public DateTime? dataEnvio { get; set; }
        public IList<DocumentoViewModel> documentos { get ; set;  }
    }
}
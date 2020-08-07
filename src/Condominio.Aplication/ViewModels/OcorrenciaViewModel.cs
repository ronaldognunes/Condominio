using System;
using System.Collections.Generic;

namespace Condominio.Aplication.ViewModels
{
    public class OcorrenciaViewModel
    {
        public int idUsuario { get; set; }
        public string Nome { get; set; }
        public string descricao { get; set; }
        public string titulo { get; set; }
        public DateTime DataRegistro { get; set; }
        public DateTime DataOcorrencia { get; set; }
        public int situacao { get; set; }
        public IList<DocumentoViewModel > documentos { get ; set;}
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Condominio.Aplication.ViewModels
{
    public class RetornoViewModel
    {
        public string MsgRetorno { get; set; }
        public IList<string> ErrosRetorno { get; set; }
    }
}

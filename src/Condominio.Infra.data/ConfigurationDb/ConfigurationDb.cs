using System;
using System.Collections.Generic;
using System.Text;

namespace Condominio.Infra.data.ConfigurationDb
{
    public class ConfigurationDb : IConfigurationDb
    {
        public string ConnectionString { get; set; }
        public string DataBaseName { get; set; }
    }
}

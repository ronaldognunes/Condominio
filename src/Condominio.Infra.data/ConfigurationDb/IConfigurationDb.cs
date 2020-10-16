using System;
using System.Collections.Generic;
using System.Text;

namespace Condominio.Infra.data.ConfigurationDb
{
    public interface IConfigurationDb
    {
        string ConnectionString { get; set; }
        string DataBaseName { get; set; }
    }
}

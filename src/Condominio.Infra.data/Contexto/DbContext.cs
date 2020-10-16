using Condominio.Infra.data.ConfigurationDb;
using MongoDB.Driver;

namespace Condominio.Infra.data.Contexto
{
    public class DbContext
    {
        public IMongoClient client {get;set;}
        public IMongoDatabase database{get;set;}

        public DbContext(IConfigurationDb settings)
        {
            client = new MongoClient(settings.ConnectionString);
            database = client.GetDatabase(settings.DataBaseName);
        }

    }
}
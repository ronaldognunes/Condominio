using MongoDB.Driver;

namespace Condominio.Infra.data.Contexto
{
    public class DbContext
    {
        public IMongoClient client {get;set;}
        public IMongoDatabase database{get;set;}

        public DbContext(string stringConnection, string nomeDataBase)
        {
            client = new MongoClient(stringConnection);
            database = client.GetDatabase(nomeDataBase);
        }

    }
}
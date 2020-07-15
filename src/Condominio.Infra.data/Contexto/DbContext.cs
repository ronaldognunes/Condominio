using MongoDB.Driver;

namespace Condominio.Infra.data.Contexto
{
    public class DbContext
    {
        public IMongoClient client {get;set;}
        public IMongoDatabase database{get;set;}

        public DbContext()
        {
            client = new MongoClient("mongodb://localhost:27017");
            database = client.GetDatabase("condominio");
        }

    }
}
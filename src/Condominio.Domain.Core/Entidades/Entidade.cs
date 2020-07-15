using Flunt.Notifications;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Condominio.Domain.Core.Entidades
{
    public abstract class Entidade :Notifiable
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }
    }
}
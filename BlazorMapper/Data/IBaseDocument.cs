using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BlazorMapper.Data
{
    public interface IBaseDocument
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        string Id { get; set; }
        DateTime LastUpdatedOn { get; }
    }
}

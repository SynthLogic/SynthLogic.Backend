﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace API.Models
{
    public class File
    {
        [BsonIgnore]
        public const string CollectionName = "instruments";
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string ContentType { get; set; }
        public long FileSize { get; set; }
        public string Content { get; set; }
    }
}
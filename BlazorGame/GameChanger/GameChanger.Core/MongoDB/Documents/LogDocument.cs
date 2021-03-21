using Convey.Types;
using Microsoft.Extensions.Logging;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.MongoDB.Documents
{
    public class LogDocument : IIdentifiable<Guid>
    {
        public Guid Id { get; set; }

        [BsonDateTimeOptions(DateOnly =false,Kind =DateTimeKind.Utc)]
        public DateTime TimeStamp { get; set; }
        public string Message { get; set; }
        public string Details { get; set; }
        public LogLevel LogLevel { get; set; } = LogLevel.Information;
    }
}

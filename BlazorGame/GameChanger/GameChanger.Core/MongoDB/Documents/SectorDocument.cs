using Convey.Types;
using GameChanger.Core.GameData;
using GameChanger.Core.MediatR.Messages.Commands.Buildings;
using GameChanger.Core.MongoDB.Documents.Buildings;
using GameChanger.Core.MongoDB.Documents.Interfaces;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.MongoDB.Documents
{
    public class SectorDocument : IIdentifiable<Guid>, IAuditedDocument
    {
        public Guid Id { get; set; }
        public Guid PlayerOwner { get; set; }

        public CityCodes CityCode { get; set; }
        public string LandCode { get; set; }

        public List<BuildingDocument> Buildings { get; set; } = new List<BuildingDocument>();
        public Guid SectorResourcesId { get; set; }
        public DateTime ModifyTimeStamp { get; set; }
        public Guid ModifiedUserId { get; set ; }
        public DateTime CreatedTimeStamp { get; set; }
        public Guid CreatedUserId { get; set ; }
    }

}

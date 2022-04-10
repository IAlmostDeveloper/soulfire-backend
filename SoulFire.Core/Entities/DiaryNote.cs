using System;
using System.Text.Json.Serialization;

namespace SoulFire.Core.Entities
{
    public class DiaryNote
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string UpdatedDate { get; set; }
    }
}

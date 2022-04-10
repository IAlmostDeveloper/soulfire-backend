using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoulFire.Core.Entities
{
    public class DiaryNoteHelp
    {
        public Guid Id { get; set; }
        public int Type { get; set; }
        public string Content { get; set; }
        public bool CanSkip { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrwlMain
{
    /// <summary>
    /// You have advantage on saving throws
    /// against being charmed, and magic can’t put you to sleep
    /// </summary>
    public class FeyAncestryAttribute : AttributeComponent
    {
        public FeyAncestryAttribute()
            : base("Fey Ancestry")
        { }
    }
}

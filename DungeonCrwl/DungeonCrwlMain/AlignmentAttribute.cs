using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrwlMain
{
    public enum MoralityAlignment
    {
        Good,
        Neutral,
        Evil
    }

    public enum SocialAlignment
    {
        Lawful,
        Neutral,
        Chaotic
    }

    public class AlignmentAttribute : AttributeComponent
    {
        public MoralityAlignment Morality { get; set; }
        public SocialAlignment Social { get; set; }

        public AlignmentAttribute()
            : base("Alignment")
        { }
    }
}

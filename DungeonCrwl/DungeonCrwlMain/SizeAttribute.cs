using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrwlMain
{
    public enum Size
    {
        Fine,
        Dimunutive,
        Tiny,
        Small,
        Medium,
        Large,
        Huge,
        Gargantuan,
        Colossal,
        ColossalPlus
    }

    public class SizeAttribute : AttributeComponent
    {
        public Size Size { get; set; }

        public SizeAttribute()
            : base("Size")
        { }
    }
}

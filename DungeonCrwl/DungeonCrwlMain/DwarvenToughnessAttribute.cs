using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrwlMain
{
    /// <summary>
    /// Your hit point maximum
    /// increases by 1, and it increases by 1 every time you
    /// gain a level.
    /// </summary>
    public class DwarvenToughnessAttribute : AttributeComponent
    {
        public DwarvenToughnessAttribute()
            : base("Dwarven Toughness")
        { }
    }
}

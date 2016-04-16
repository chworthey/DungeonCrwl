using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrwlMain
{
    /// <summary>
    /// Your speed is not reduced by wearing heavy armor.
    /// </summary>
    public class DwarvenHeavyArmorSpeedReductionAttribute : AttributeComponent
    {
        public DwarvenHeavyArmorSpeedReductionAttribute()
            : base("Dwarven Heavy Armor Speed Reduction")
        { }
    }
}

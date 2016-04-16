using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrwlMain
{
    /// <summary>
    /// You have advantage on saving
    /// throws against poison, and you have resistance against
    /// poison damage
    /// </summary>
    public class DwarvenResilianceAttribute : AttributeComponent
    {
        public DwarvenResilianceAttribute()
            : base("Dwarven Resiliance")
        {
        }
    }
}

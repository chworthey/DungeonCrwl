using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrwlMain
{
    public enum ArmorType
    {
        Light,
        Medium,
        Heavy
    }

    public class ArmorProficiencyAttribute : AttributeComponent
    {
        public ArmorType Armor { get; set; }

        public ArmorProficiencyAttribute()
            : base("Armor Proficiency")
        { }
    }
}

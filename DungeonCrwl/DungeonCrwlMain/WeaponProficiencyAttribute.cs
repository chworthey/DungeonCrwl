using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrwlMain
{
    public enum WeaponType
    {
        Battleaxe,
        Handaxe,
        LightHammer,
        Warhammer,
        LongSword,
        ShortSword,
        ShortBow,
        LongBow
    }

    public class WeaponProficiencyAttribute : AttributeComponent
    {
        public WeaponType Weapon { get; set; }

        public WeaponProficiencyAttribute()
            : base("Weapon Proficiency")
        {
        }
    }
}

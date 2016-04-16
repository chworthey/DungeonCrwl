using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrwlMain
{
    public abstract class RaceAttribute : AttributeComponent
    {
        public RaceAttribute(string raceName)
            : base(raceName + " Race")
        { }

        public abstract void AdjustForRace(GameObject obj);
    }

    public abstract class DwarfAttribute : RaceAttribute
    {
        public DwarfAttribute(string raceName)
            : base(raceName)
        { }

        public override void AdjustForRace(GameObject obj)
        {
            ConstitutionAbilityAttribute constitution = obj.Attributes.OfType<ConstitutionAbilityAttribute>().First();
            constitution.Value += 2;

            SizeAttribute size = obj.Attributes.OfType<SizeAttribute>().First();
            size.Size = Size.Medium;

            DarkVisionDistanceAttribute vision = obj.Attributes.OfType<DarkVisionDistanceAttribute>().First();
            vision.Value = 60;

            obj.Attributes.Add(new DwarvenResilianceAttribute());

            obj.Attributes.Add(new WeaponProficiencyAttribute() { Weapon = WeaponType.Battleaxe });
            obj.Attributes.Add(new WeaponProficiencyAttribute() { Weapon = WeaponType.Handaxe });
            obj.Attributes.Add(new WeaponProficiencyAttribute() { Weapon = WeaponType.LightHammer });
            obj.Attributes.Add(new WeaponProficiencyAttribute() { Weapon = WeaponType.Warhammer });

            obj.Attributes.Add(new LanguageAttribute() { Value = "Common" });
            obj.Attributes.Add(new LanguageAttribute() { Value = "Dwarvish" });

            AdjustForRaceImpl(obj);
        }

        protected abstract void AdjustForRaceImpl(GameObject obj);
    }

    public class HillDwarfAttribute : DwarfAttribute
    {
        public HillDwarfAttribute()
            : base("Hill Dwarf")
        { }

        protected override void AdjustForRaceImpl(GameObject obj)
        {
            WisdomAbilityAttribute wisdom = obj.Attributes.OfType<WisdomAbilityAttribute>().First();
            wisdom.Value++;

            obj.Attributes.Add(new DwarvenToughnessAttribute());
        }
    }

    public class MountainDwarfAttribute : DwarfAttribute
    {
        public MountainDwarfAttribute()
            : base("Mountain Dwarf")
        { }

        protected override void AdjustForRaceImpl(GameObject obj)
        {
            StrengthAbilityAttribute strength = obj.Attributes.OfType<StrengthAbilityAttribute>().First();
            strength.Value += 2;

            obj.Attributes.Add(new ArmorProficiencyAttribute() { Armor = ArmorType.Light });
            obj.Attributes.Add(new ArmorProficiencyAttribute() { Armor = ArmorType.Medium });
        }
    }

    public abstract class ElfAttribute : RaceAttribute
    {
        public ElfAttribute(string raceName)
            : base(raceName)
        { }

        public override void AdjustForRace(GameObject obj)
        {
            AdjustForRaceImpl(obj);
        }

        protected abstract void AdjustForRaceImpl(GameObject obj);
    }

    public class HighElfAttribute : ElfAttribute
    {
        public HighElfAttribute()
            : base("High Elf")
        { }

        protected override void AdjustForRaceImpl(GameObject obj)
        {

        }
    }

    public class WoodElfAttribute : ElfAttribute
    {
        public WoodElfAttribute()
            : base("Wood Elf")
        { }

        protected override void AdjustForRaceImpl(GameObject obj)
        {

        }
    }

    public abstract class HalflingAttribute : RaceAttribute
    {
        public HalflingAttribute(string raceName)
            : base(raceName)
        { }

        public override void AdjustForRace(GameObject obj)
        {
            AdjustForRaceImpl(obj);
        }

        protected abstract void AdjustForRaceImpl(GameObject obj);
    }

    public class LightFootHalflingAttribute : HalflingAttribute
    {
        public LightFootHalflingAttribute()
            : base("Light Foot Halfling")
        { }

        protected override void AdjustForRaceImpl(GameObject obj)
        {

        }
    }

    public class StoutHalflingAttribute : HalflingAttribute
    {
        public StoutHalflingAttribute()
            : base("Stout Foot Halfling")
        { }

        protected override void AdjustForRaceImpl(GameObject obj)
        {

        }
    }

    public class Human : RaceAttribute
    {
        public Human()
            : base("Human")
        { }

        public override void AdjustForRace(GameObject obj)
        {

        }
    }
}

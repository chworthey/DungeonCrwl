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

        /// <summary>
        /// This will add bonuses and make adjustments to the character given based on racial traits
        /// </summary>
        /// <param name="character">The character to make adjustments to</param>
        public abstract void AdjustRacialTraits(GameObject character);
    }

    public abstract class DwarfAttribute : RaceAttribute
    {
        public DwarfAttribute(string raceName)
            : base(raceName)
        { }

        public override void AdjustRacialTraits(GameObject character)
        {
            ConstitutionScoreAttribute constitution = character.Attributes.OfType<ConstitutionScoreAttribute>().First();
            constitution.Value += 2;

            SizeAttribute size = character.Attributes.OfType<SizeAttribute>().First();
            size.Size = Size.Medium;

            SpeedAttribute speed = character.Attributes.OfType<SpeedAttribute>().First();
            speed.Value = 25;

            character.Attributes.Add(new DwarvenHeavyArmorSpeedReductionAttribute());

            DarkVisionAttribute vision = character.Attributes.OfType<DarkVisionAttribute>().First();
            vision.Value = 60;

            character.Attributes.Add(new DwarvenResilianceAttribute());

            character.Attributes.Add(new WeaponProficiencyAttribute() { Weapon = WeaponType.Battleaxe });
            character.Attributes.Add(new WeaponProficiencyAttribute() { Weapon = WeaponType.Handaxe });
            character.Attributes.Add(new WeaponProficiencyAttribute() { Weapon = WeaponType.LightHammer });
            character.Attributes.Add(new WeaponProficiencyAttribute() { Weapon = WeaponType.Warhammer });

            character.Attributes.Add(new LanguageAttribute() { Value = "Common" });
            character.Attributes.Add(new LanguageAttribute() { Value = "Dwarvish" });

            AdjustRacialTraitsImpl(character);
        }

        protected abstract void AdjustRacialTraitsImpl(GameObject character);
    }

    public class HillDwarfAttribute : DwarfAttribute
    {
        public HillDwarfAttribute()
            : base("Hill Dwarf")
        { }

        protected override void AdjustRacialTraitsImpl(GameObject character)
        {
            WisdomScoreAttribute wisdom = character.Attributes.OfType<WisdomScoreAttribute>().First();
            wisdom.Value++;

            character.Attributes.Add(new DwarvenToughnessAttribute());
        }
    }

    public class MountainDwarfAttribute : DwarfAttribute
    {
        public MountainDwarfAttribute()
            : base("Mountain Dwarf")
        { }

        protected override void AdjustRacialTraitsImpl(GameObject character)
        {
            StrengthScoreAttribute strength = character.Attributes.OfType<StrengthScoreAttribute>().First();
            strength.Value += 2;

            character.Attributes.Add(new ArmorProficiencyAttribute() { Armor = ArmorType.Light });
            character.Attributes.Add(new ArmorProficiencyAttribute() { Armor = ArmorType.Medium });
        }
    }

    public abstract class ElfAttribute : RaceAttribute
    {
        public ElfAttribute(string raceName)
            : base(raceName)
        { }

        public override void AdjustRacialTraits(GameObject character)
        {
            throw new NotImplementedException();
        }

        protected abstract void AdjustRacialTraitsImpl(GameObject character);
    }

    public class HighElfAttribute : ElfAttribute
    {
        public HighElfAttribute()
            : base("High Elf")
        { }

        protected override void AdjustRacialTraitsImpl(GameObject character)
        {
            throw new NotImplementedException();
        }
    }

    public class WoodElfAttribute : ElfAttribute
    {
        public WoodElfAttribute()
            : base("Wood Elf")
        { }

        protected override void AdjustRacialTraitsImpl(GameObject character)
        {
            throw new NotImplementedException();
        }
    }

    public abstract class HalfingAttribute : RaceAttribute
    {
        public HalfingAttribute(string raceName)
            : base(raceName)
        { }

        public override void AdjustRacialTraits(GameObject character)
        {
            throw new NotImplementedException();
        }

        protected abstract void AdjustRacialTraitsImpl(GameObject character);
    }

    public class LightfootHalflingAttribute : HalfingAttribute
    {
        public LightfootHalflingAttribute(string raceName)
            : base("Lightfoot Halfling")
        { }

        protected override void AdjustRacialTraitsImpl(GameObject character)
        {
            throw new NotImplementedException();
        }
    }

    public class StoutHalflingAttribute : HalfingAttribute
    {
        public StoutHalflingAttribute(string raceName)
            : base("Stout Halfling")
        { }

        protected override void AdjustRacialTraitsImpl(GameObject character)
        {
            throw new NotImplementedException();
        }
    }

    public class Human : RaceAttribute
    {
        public Human()
            : base("Human")
        { }

        public override void AdjustRacialTraits(GameObject character)
        {
            throw new NotImplementedException();
        }
    }
}

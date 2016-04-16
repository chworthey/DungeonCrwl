using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrwlMain
{
    public abstract class AbilityScoreAttribute : IntegerAttribute
    {
        static Random rnd = new Random();

        public AbilityScoreAttribute(string componentName)
            : base(componentName + " Ability Score")
        { }

        public int CalculateModifier()
        {
            return Value / 2 - 5;
        }

        public void RollRandomly()
        {
            List<int> rolls = new List<int>();
            for (int n = 0; n < 4; n++)
                rolls.Add(rnd.Next(1, 6));

            int roll1 = rolls.Max();
            rolls.Remove(roll1);
            int roll2 = rolls.Max();
            rolls.Remove(roll2);
            int roll3 = rolls.Max();
            rolls.Remove(roll3);

            Value = roll1 + roll2 + roll3;
        }
    }

    public class StrengthAbilityAttribute : AbilityScoreAttribute
    {
        public StrengthAbilityAttribute()
            : base("Strength")
        { }
    }

    public class DexterityAbilityAttribute : AbilityScoreAttribute
    {
        public DexterityAbilityAttribute()
            : base("Dexterity")
        { }
    }

    public class ConstitutionAbilityAttribute : AbilityScoreAttribute
    {
        public ConstitutionAbilityAttribute()
            : base("Constitution")
        { }
    }

    public class IntelligenceAbilityAttribute : AbilityScoreAttribute
    {
        public IntelligenceAbilityAttribute()
            : base("Intelligence")
        { }
    }

    public class WisdomAbilityAttribute : AbilityScoreAttribute
    {
        public WisdomAbilityAttribute()
            : base("Wisdom")
        { }
    }

    public class CharismaAbilityAttribute : AbilityScoreAttribute
    {
        public CharismaAbilityAttribute()
            : base("Charisma")
        { }
    }
}

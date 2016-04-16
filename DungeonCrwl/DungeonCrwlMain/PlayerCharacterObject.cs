using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrwlMain
{
    public class PlayerCharacterObject : GameObject
    {
        public PlayerCharacterObject()
        {
            // Main attributes
            Attributes.Add(new NameAttribute());

            // Ability Scores
            Attributes.Add(new StrengthAbilityAttribute());
            Attributes.Add(new DexterityAbilityAttribute());
            Attributes.Add(new ConstitutionAbilityAttribute());
            Attributes.Add(new IntelligenceAbilityAttribute());
            Attributes.Add(new WisdomAbilityAttribute());
            Attributes.Add(new CharismaAbilityAttribute());

            // Racial Traits
            Attributes.Add(new AgeAttribute());
            Attributes.Add(new AlignmentAttribute());
            Attributes.Add(new SizeAttribute());
            Attributes.Add(new SpeedAttribute());
            Attributes.Add(new LanguageAttribute());
            Attributes.Add(new DarkVisionDistanceAttribute());
        }
    }
}

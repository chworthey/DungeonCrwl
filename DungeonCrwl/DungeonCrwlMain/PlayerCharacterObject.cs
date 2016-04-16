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
            // Ability scores
            Attributes.Add(new StrengthScoreAttribute());
            Attributes.Add(new DexterityScoreAttribute());
            Attributes.Add(new ConstitutionScoreAttribute());
            Attributes.Add(new IntelligenceScoreAttribute());
            Attributes.Add(new WisdomScoreAttribute());
            Attributes.Add(new CharismaScoreAttribute());

            // Racial traits
            Attributes.Add(new AgeAttribute());
            Attributes.Add(new AlignmentAttribute());
            Attributes.Add(new SizeAttribute());
            Attributes.Add(new SpeedAttribute());
            Attributes.Add(new DarkVisionAttribute());
        }
    }
}

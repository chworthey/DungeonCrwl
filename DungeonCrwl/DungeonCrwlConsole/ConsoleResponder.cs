using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonCrwlMain;

namespace DungeonCrwlConsole
{
    class ConsoleResponder : DungeonCrwlMain.IResponder
    {
        public void ChangeBackgroundColor()
        {
            Console.WriteLine("Behold! The color before you changes to a stunning red. 2 seconds later, it changes to a stunning blue!");
        }

        public PlayerCharacterObject CreateCharacter()
        {
            PlayerCharacterObject player = new PlayerCharacterObject();

            var characterAbilityScores = player.Attributes.OfType<AbilityScoreAttribute>();

            foreach (AbilityScoreAttribute ability in characterAbilityScores)
            {
                ability.RandomlyRollScore();
            }

            RaceAttribute race = new MountainDwarfAttribute();
            player.Attributes.Add(race);

            race.AdjustRacialTraits(player);

            return player;
        }

        public void ShowPlayerCharacterInformation(PlayerCharacterObject player)
        {
            var characterAbilityScores = player.Attributes.OfType<AbilityScoreAttribute>();

            foreach (AbilityScoreAttribute ability in characterAbilityScores)
            {
                int modifier = ability.CalculateModifier();
                Console.WriteLine(ability.ComponentName + ": " + ability.Value.ToString() +
                    " (" + (modifier > 0 ? "+" : "") + modifier.ToString() + ")");
            }

            foreach (AttributeComponent component in player.Attributes)
            {
                Console.WriteLine(component.ComponentName);
            }
        }
    }
}

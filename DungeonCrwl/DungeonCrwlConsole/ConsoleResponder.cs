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

            // Roll ability scores
            var abilityScores = player.Attributes.OfType<AbilityScoreAttribute>();
            foreach (var abilityScore in abilityScores)
            {
                abilityScore.RollRandomly();
            }

            // Create a dwarf
            RaceAttribute dwarfRace = new MountainDwarfAttribute();
            player.Attributes.Add(dwarfRace);

            dwarfRace.AdjustForRace(player);

            return player;
        }

        public void ShowCharacterAttributes(PlayerCharacterObject player)
        {
            var abilityScores = player.Attributes.OfType<AbilityScoreAttribute>();

            Console.WriteLine("Ability scores:");
            foreach (var abilityScore in abilityScores)
            {
                int abilityModifier = abilityScore.CalculateModifier();
                Console.WriteLine(abilityScore.Value.ToString() + " (" + 
                    (abilityModifier > 0 ? "+" : "") + 
                    abilityModifier.ToString() + ")");
            }

            Console.WriteLine("All components:");

            foreach (AttributeComponent component in player.Attributes)
                Console.WriteLine(component.ComponentName);
        }
    }
}

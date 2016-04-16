using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrwlMain
{
    public class DungeonCrwlMain
    {
        public void Run(IResponder responder)
        {
            responder.ChangeBackgroundColor();
            PlayerCharacterObject player = responder.CreateCharacter();
            responder.ShowCharacterAttributes(player);
        }
    }
}

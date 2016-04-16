using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrwlMain
{
    public interface IResponder
    {
        void ChangeBackgroundColor();
        PlayerCharacterObject CreateCharacter();
        void ShowCharacterAttributes(PlayerCharacterObject player);
    }
}

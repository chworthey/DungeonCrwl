using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrwlConsole
{
    class ConsoleResponder : DungeonCrwlMain.IResponder
    {
        public void ChangeBackgroundColor()
        {
            Console.WriteLine("Behold! The color before you changes to a stunning red. 2 seconds later, it changes to a stunning blue!");
        }
    }
}

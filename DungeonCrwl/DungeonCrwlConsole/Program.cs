using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrwlConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Console game has started...");

            DungeonCrwlMain.DungeonCrwlMain main = new DungeonCrwlMain.DungeonCrwlMain();
            ConsoleResponder responder = new ConsoleResponder();

            main.Run(responder);

            Console.WriteLine("Console game has ended...");
            Console.ReadKey();
        }
    }
}

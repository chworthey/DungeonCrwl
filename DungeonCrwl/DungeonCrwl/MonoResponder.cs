using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using System.Threading;
using DungeonCrwlMain;

namespace DungeonCrwl
{
    class MonoResponder : DungeonCrwlMain.IResponder
    {
        Game1 game;
        EventWaitHandle waitHandle = new AutoResetEvent(false);

        public MonoResponder(Game1 game)
        {
            this.game = game;
        }

        void suspend(TimeSpan timeout)
        {
            waitHandle.WaitOne(timeout);
        }

        void resume()
        {
            waitHandle.Set();
        }

        public void ChangeBackgroundColor()
        {
            game.BackgroundColor = Color.Red;
            suspend(TimeSpan.FromSeconds(2.0));
            game.BackgroundColor = Color.Blue;
        }

        public PlayerCharacterObject CreateCharacter()
        {
            throw new NotImplementedException();
        }

        public void ShowCharacterAttributes(PlayerCharacterObject player)
        {
            throw new NotImplementedException();
        }
    }
}

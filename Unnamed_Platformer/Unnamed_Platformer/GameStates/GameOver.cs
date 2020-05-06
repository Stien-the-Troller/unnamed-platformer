using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unnamed_Platformer.GameStates
{
    class GameOver: GameObjectList
    {
        public GameOver() : base()
        {
            this.Add(new SpriteGameObject("titlescreen"));
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);
            if (inputHelper.AnyKeyPressed)
            {
                UnnamedPlatformer.GameStateManager.SwitchTo("playingstate");
            }
        }
    }
}

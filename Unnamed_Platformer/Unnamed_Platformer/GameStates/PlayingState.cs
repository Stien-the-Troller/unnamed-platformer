using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unnamed_Platformer.GameObjects;

namespace Unnamed_Platformer.GameStates
{
    class PlayingState : GameObjectList
    {
        public PlayingState() : base() {
            this.Add(new SpriteGameObject("background"));
            this.Add(new Ground());
            this.Add(new Player());
        }
    }
}

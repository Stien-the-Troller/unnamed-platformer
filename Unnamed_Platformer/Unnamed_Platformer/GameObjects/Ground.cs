using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Unnamed_Platformer.GameObjects
{
    class Ground : SpriteGameObject
    {
        public Ground() : base("ground")
        {
            position = new Vector2(0, 450);
        }
    }
}

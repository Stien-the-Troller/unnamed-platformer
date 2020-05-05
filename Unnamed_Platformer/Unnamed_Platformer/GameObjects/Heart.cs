using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unnamed_Platformer.GameObjects
{
    class Heart : SpriteGameObject
    {
        public Heart(Vector2 position): base("heart")
        {
            this.position = position;
        }
    }
}

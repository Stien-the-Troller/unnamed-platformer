using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Unnamed_Platformer.GameObjects
{
    class Player : SpriteGameObject
    {
        public Player() : base("mario_sprite")
        {

            position = new Vector2(50,400);
        }
    }
}

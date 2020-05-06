using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unnamed_Platformer.GameObjects
{
    class Enemy : SpriteGameObject
    {
        int timer = 0;
        bool side = false;
        public Enemy(Vector2 position) : base("enemy")
        {
            this.position = position;
        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            velocity.X = 0;
            if (side)
            {
                if (timer >= 30)
                {
                    side = false; 
                    timer = 0;
                }
                velocity.X = 30;
                timer++;
            }
            else if (!side)
            {
                if (timer >= 30)
                {
                    side = true;
                    timer = 0;
                }
                velocity.X = -30;
                timer++;
            }
            
        }
    }
}

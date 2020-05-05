using Microsoft.Xna.Framework;
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
        public Player player = new Player();
        public PlayingState() : base()
        {
            //this.Add(new SpriteGameObject("background"));
            this.Add(player);
            this.Add(new Ground());

        }
        public override void Update(GameTime gameTime)
        {
            
            base.Update(gameTime);
            int collideCount = 0;
            foreach (SpriteGameObject ground in Children)
            {
                if (!(ground is Player))
                {
                    if (player.CollidesWith(ground))
                    {
                        player.Grounded();
                        collideCount++;
                    }
                }
            }
            if (collideCount == 0)
            {
                player.grounded = false;
            }
        }
    }
}

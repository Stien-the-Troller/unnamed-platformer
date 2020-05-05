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
        public SpriteGameObject background = new SpriteGameObject("background");
        public Life life = new Life();
        public GameObjectList obstakels = new GameObjectList();
        public Level1 level1 = new Level1();
        public PlayingState() : base()
        {
            this.Add(background);
            this.Add(player);
            this.Add(life);
            this.Add(obstakels);
            this.Add(level1);
            obstakels.Add(new Ground());
            

        }
        public override void Update(GameTime gameTime)
        {
            
            base.Update(gameTime);
            int collideCount = 0;

            level1.Position -= new Vector2(player.Velocity.X, 0)*(float)gameTime.ElapsedGameTime.TotalSeconds;
            foreach (SpriteGameObject obstakel in level1.Children)
            {
                if (obstakel is Ground || obstakel is Block)
                {
                    if (player.CollidesWith(obstakel))
                    {
                        
                        if(player.Position.X +player.Width >= obstakel.Position.X && player.Position.X <= obstakel.Position.X + obstakel.Width && player.Position.Y >=obstakel.Position.Y +obstakel.Height)
                        {
                            player.Velocity += new Vector2(0, -player.Velocity.Y);
                        }
                            player.Grounded();
                        
                        collideCount++;
                    }
                }
            }
            foreach (SpriteGameObject obstakel in obstakels.Children)
            {
                if (obstakel is Ground || obstakel is Block)
                {
                    if (player.CollidesWith(obstakel))
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

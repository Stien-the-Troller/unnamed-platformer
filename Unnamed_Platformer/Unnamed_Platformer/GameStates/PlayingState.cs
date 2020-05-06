using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unnamed_Platformer.GameObjects;
using Microsoft.Xna.Framework.Input;

namespace Unnamed_Platformer.GameStates
{
    class PlayingState : GameObjectList
    {
        public Player player = new Player();
        public SpriteGameObject background = new SpriteGameObject("background");
        public Life life = new Life();
        public GameObjectList obstakels = new GameObjectList();
        public Level1 level1 = new Level1();
        public Bullet bullet = new Bullet();
        public PlayingState() : base()
        {
            this.Add(background);
            this.Add(player);
            this.Add(life);
            this.Add(obstakels);
            this.Add(level1);
            this.Add(bullet);
            obstakels.Add(new Ground());


        }
        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);
            if (inputHelper.KeyPressed(Keys.Space)) 
            {
                bullet.Position = player.Position;
                bullet.Velocity = new Vector2(600, 0);
                Console.WriteLine("shoot");
            }
        }
        public override void Update(GameTime gameTime)
        {

            base.Update(gameTime);

            player.headbump = false;
            player.grounded = false;
            player.lefthit = false;
            player.righthit = false;
            level1.Position -= new Vector2(player.Velocity.X, 0) * (float)gameTime.ElapsedGameTime.TotalSeconds;

            foreach(SpriteGameObject enemy in level1.enemies.Children)
            {
                if (enemy.Visible)
                {
                    if (player.CollidesWith(enemy))
                    {
                        bool take = true;
                        foreach (Heart heart in life.hearts.Children)
                        {
                            if (heart.Visible && take)
                            {
                                heart.Visible = false;
                                take = false;
                                level1.Position = new Vector2(0, 0);
                            }
                        }
                        if (take)
                        {
                            UnnamedPlatformer.GameStateManager.SwitchTo("gameover");
                        }
                    }
                    if (bullet.CollidesWith(enemy))
                    {
                        enemy.Visible = false;
                        bullet.Position = new Vector2(-10, -10);
                        bullet.Velocity = new Vector2(0, 0);
                    }
                }
            }
            if (player.CollidesWith(level1.finish))
            {
                UnnamedPlatformer.GameStateManager.SwitchTo("victory");
            }
            foreach (SpriteGameObject obstakel in level1.blocks.Children)
            {
                if (bullet.CollidesWith(obstakel))
                {
                    bullet.Position = new Vector2(-10, -10);
                    bullet.Velocity = new Vector2(0, 0);
                }
                if (obstakel is Ground || obstakel is Block)
                {
                    if (player.CollidesWith(obstakel))
                    {


                        if (player.Position.Y < obstakel.Position.Y)
                        {
                            Console.WriteLine("feet");
                            player.Grounded();

                        }


                        else if (player.Position.Y  > obstakel.Position.Y + obstakel.Height)
                        {
                            Console.WriteLine("head");
                            player.headbump = true;
                            player.Velocity += new Vector2(0, -player.Velocity.Y );

                        }

                         else if (player.Position.X < obstakel.Position.X + level1.Position.X)
                        {
                            Console.WriteLine("right");
                            player.righthit = true;
                            player.Velocity += new Vector2(-player.Velocity.X , 0);

                        }


                        else if (player.Position.X > obstakel.Position.X + level1.Position.X)
                        {
                            Console.WriteLine("left");
                            player.lefthit = true;
                            player.Velocity += new Vector2(-player.Velocity.X , 0);

                        }


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

                    }
                }
            }

        }
    }
}

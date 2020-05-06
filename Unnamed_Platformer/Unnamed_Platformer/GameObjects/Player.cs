using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Unnamed_Platformer.GameObjects
{
    class Player : SpriteGameObject
    {
        int gravity = 10;
        public bool grounded = true;
        public bool headbump = false;
        public bool lefthit = false;
        public bool righthit = false;
        public Player() : base("mario_sprite")
        {
            origin = new Vector2(sprite.Width / 2, sprite.Height / 2);
            position = new Vector2(100,400);
        }
        public override void HandleInput(InputHelper inputHelper)
        {
            velocity.X *= 0.9f;
            base.HandleInput(inputHelper);
            if (!(velocity.X < -500))
            {
                
                if (!lefthit)
                {
                    
                    if (inputHelper.IsKeyDown(Keys.Left))
                    {
                        //Console.WriteLine("aaaah");
                        velocity.X += -50;
                    }
                }
            }
            if (!(velocity.X > 500))
            {
                if (!righthit)
                {
                    if (inputHelper.IsKeyDown(Keys.Right))
                    {
                        velocity.X += 50;
                    }
                }
            }
            if (grounded && !headbump)
            {
                if (inputHelper.IsKeyDown(Keys.Up))
                {
                    velocity.Y = -400;
                }
            }
        }
        public override void Update(GameTime gameTime)
        {
            //base.Update(gameTime);
            position.Y += velocity.Y * (float)gameTime.ElapsedGameTime.TotalSeconds;
            velocity.Y += gravity;
            if(velocity.X < 0.1 && velocity.X > -0.1)
            {
                velocity.X = 0;
            }
        }
        public void Grounded()
        {
            velocity.Y = 0;
            grounded = true;
        }
    }
}

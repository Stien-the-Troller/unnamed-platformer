﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unnamed_Platformer.GameObjects
{
    class Block : SpriteGameObject
    {
        public Block(Vector2 position) : base("block_sprite") 
        {
            this.position = position;
        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            //Console.WriteLine("wtf");
        }
    }
}

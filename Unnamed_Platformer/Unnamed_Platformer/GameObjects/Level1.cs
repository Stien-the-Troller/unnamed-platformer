using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unnamed_Platformer.GameObjects
{
    class Level1 : GameObjectList
    {
        public Level1() : base()
        {
            this.Add(new Block(new Vector2(400,300)));
            
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            
        }
    }
}

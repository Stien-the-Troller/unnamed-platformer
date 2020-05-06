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
        public GameObjectList blocks = new GameObjectList();
        public GameObjectList enemies = new GameObjectList();
        public LevelEnd finish = new LevelEnd(2000);
        public Level1() : base()
        {
            this.Add(blocks);
            this.Add(enemies);
            this.Add(finish);
            blocks.Add(new Block(new Vector2(400, 400)));
            blocks.Add(new Block(new Vector2(400, 350)));
            blocks.Add(new Block(new Vector2(450, 350)));
            blocks.Add(new Block(new Vector2(200, 300)));
            enemies.Add(new Enemy(new Vector2(200, 300)));
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

        }
    }
}

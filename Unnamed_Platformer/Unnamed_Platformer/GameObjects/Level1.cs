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
        public TextGameObject controls = new TextGameObject("GameFont");
        public Level1() : base()
        {
            this.Add(blocks);
            this.Add(enemies);
            this.Add(finish);
            this.Add(controls);

            controls.Text = "arrows to move, space to shoot";
            controls.Position = new Vector2(100, 100);
            blocks.Add(new Block(new Vector2(300, 300)));
            blocks.Add(new Block(new Vector2(250, 300)));
            blocks.Add(new Block(new Vector2(200, 300)));
            blocks.Add(new Block(new Vector2(400, 400)));
            blocks.Add(new Block(new Vector2(450, 400)));
            blocks.Add(new Block(new Vector2(450, 350)));
            blocks.Add(new Block(new Vector2(500, 200)));
            blocks.Add(new Block(new Vector2(550, 200)));
            blocks.Add(new Block(new Vector2(600, 200)));
            blocks.Add(new Block(new Vector2(650, 200)));
            blocks.Add(new Block(new Vector2(700, 400)));
            blocks.Add(new Block(new Vector2(700, 350)));
            blocks.Add(new Block(new Vector2(750, 400)));
            blocks.Add(new Block(new Vector2(1300, 400)));
            blocks.Add(new Block(new Vector2(1300, 350)));

            blocks.Add(new Block(new Vector2(1500, 400)));
            blocks.Add(new Block(new Vector2(1500, 350)));
            blocks.Add(new Block(new Vector2(1500, 300)));
            blocks.Add(new Block(new Vector2(1500, 250)));






            enemies.Add(new Enemy(new Vector2(200, 200)));
            enemies.Add(new Enemy(new Vector2(550, 350)));
            enemies.Add(new Enemy(new Vector2(550, 100)));
            enemies.Add(new Enemy(new Vector2(1550, 350)));
            enemies.Add(new Enemy(new Vector2(1700, 350)));
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

        }
    }
}

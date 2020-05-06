using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Unnamed_Platformer.GameObjects
{
    class Life : GameObjectList
    {
        public TextGameObject text = new TextGameObject("GameFont");
        public TextGameObject points = new TextGameObject("GameFont");   
        public GameObjectList hearts = new GameObjectList();
        public Life() : base()
        {
            position = new Vector2(500, 30);
            this.Add(text);
            this.Add(points);
            this.Add(hearts);
            hearts.Add(new Heart(new Vector2(70, 0)));
            hearts.Add(new Heart(new Vector2(120, 0)));
            hearts.Add(new Heart(new Vector2(170, 0)));
            text.Text = "life";
            points.Text = "point total = " + 0;
            points.Position = new Vector2(-500, 0);
            points.Color = Color.Purple;
            text.Color = Color.Purple;
        }
    }
}

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
        public Life() : base()
        {
            position = new Vector2(500, 30);
            this.Add(text);
            this.Add(new Heart(new Vector2(70, 0)));
            this.Add(new Heart(new Vector2(120, 0)));
            this.Add(new Heart(new Vector2(170, 0)));
            text.Text = "life";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unnamed_Platformer.GameObjects
{
    class LevelEnd : SpriteGameObject
    {
        public LevelEnd(int location) : base("flag")
        {
            position.X = location;
        }
    }
}

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using ShooterTest.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2.Game.GameObjects
{
    public class Raindrop : GameObject, ICollidable
    {
        public Rectangle BoxCollider
        {
            get
            {
                return new Rectangle((int)location.X, (int)location.Y, (int)size.X, (int)size.Y);
            }
        }
        public Raindrop(ContentManager content, string spriteName, string name) : base(content, spriteName, name)
        {

        }

        public void OnCollision(ICollidable other)
        {
            throw new NotImplementedException();
        }
    }
}

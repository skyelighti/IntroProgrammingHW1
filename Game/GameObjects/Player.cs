using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2.Game.GameObjects
{
    public class Player : GameObject, ICollidable
    {
        public Rectangle BoxCollider
        {
            get
            {
                return new Rectangle((int)location.X, (int)location.Y, (int)size.X, (int)size.Y);
            }
            //returns new rect everytime its called, so its always accurate
        }

        public Player(ContentManager content, string spriteName, string name) : base(content, spriteName, name)
        {
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }
        public void OnCollision(ICollidable other)
        {
            throw new NotImplementedException();
        }

    }
}

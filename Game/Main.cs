using Homework2.Game;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGameLibrary.Graphics;
using System;
using System.Diagnostics;
using System.Numerics;
using System.Reflection.Metadata;
namespace ShooterTest.Game
{
    public class Main
    {
        public static Rectangle ScreenBounds;
        public static ContentManager contentManager { get; private set; }
        private CollisionManager collisionManager;

        public static TextureAtlas atlas { get; private set; }

        public Main(ContentManager content)
        {
            contentManager = content;


            collisionManager = new CollisionManager(content);

        }

        //maybe implement a statemaachine for game state? :P extra work to do if i hate reading!!
        public void Update(GameTime gameTime, Rectangle screenBounds)
        {
            // update everything else here as well?
            ScreenBounds = screenBounds;
            collisionManager.Update(gameTime);
        }
        public void Draw(SpriteBatch spriteBatch)
        {

        }
    }
}

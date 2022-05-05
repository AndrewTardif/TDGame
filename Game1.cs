using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace MyGame
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public static Game1 Instance { get; private set; }
        public static Viewport Viewport { get { return Instance.GraphicsDevice.Viewport; } }
        public static Vector2 ScreenSize { get { return new Vector2(Viewport.Width, Viewport.Height); } }

        int _width;
        int _height;
        int randNum1;
        int randNum2;
        int randNum3;
        Random random;

        int levelCount;
        Texture2D wallSprite;
        Texture2D wallCornerLeftSprite;
        Texture2D wallCornerRightSprite;
        Texture2D chestSprite;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            Instance = this;


        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferHeight = 800;
            _graphics.PreferredBackBufferWidth = 1008;
            _graphics.ApplyChanges();
            _width = _graphics.PreferredBackBufferWidth;
            _height = _graphics.PreferredBackBufferHeight;

            levelCount = 1;

            random = new Random();

            randNum1 = random.Next(1,62);
            randNum2 = random.Next(1,62);
            randNum3 = random.Next(1,62);

            base.Initialize();
           
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            Art.Load(Content);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();
            _spriteBatch.Draw(chestSprite, new Vector2(randNum1 * 16, 16), Color.White);
            _spriteBatch.Draw(chestSprite, new Vector2(randNum2 * 16, 16), Color.White);
            _spriteBatch.Draw(chestSprite, new Vector2(randNum3 * 16, 16), Color.White);
            for (int i = 16; i < (_width-16); i+=16)
            { 
                _spriteBatch.Draw(wallSprite, new Vector2(i, 0), Color.White);
                _spriteBatch.Draw(wallSprite, new Vector2(i, (_height-16)), Color.White);


            }
            for (int j = 0; j<_height; j+=16)
            {
                _spriteBatch.Draw(wallCornerLeftSprite, new Vector2(0, j), Color.White);
                _spriteBatch.Draw(wallCornerRightSprite, new Vector2((_width - 16), j), Color.White);
            }
            

            _spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}

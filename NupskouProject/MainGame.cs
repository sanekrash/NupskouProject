using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace NupskouProject
{
    public class MainGame : Game
    {
        public GraphicsDeviceManager graphicsDevice;
        public SpriteBatch spriteBatch;
        
        public MainGame()
        {
            graphicsDevice = new GraphicsDeviceManager(this)
            {
                PreferredBackBufferWidth = 1050,
                PreferredBackBufferHeight = 750,
                
                PreferMultiSampling = true,
                
            };
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            The.Assets.Load(Content);
        }

        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back ==
                ButtonState.Pressed || Keyboard.GetState().IsKeyDown(
                    Keys.Escape))
            {
                Exit();
            }
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            spriteBatch.Begin();
            spriteBatch.Draw(The.Assets.SidePanel, new Rectangle(600,0,450,750), Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}

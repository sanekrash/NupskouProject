using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace NupskouProject {

    public class MainGame : Game {

        private GraphicsDeviceManager _graphicsDevice;
        private SpriteBatch           _spriteBatch;


        public MainGame () {
            _graphicsDevice = new GraphicsDeviceManager (this) {
                PreferredBackBufferWidth  = 1050,
                PreferredBackBufferHeight = 750,
                PreferMultiSampling       = true,
            };
        }


        protected override void Initialize () {
            
            base.Initialize ();

        }


        protected override void LoadContent () {
            The.SpriteBatch = _spriteBatch = new SpriteBatch (GraphicsDevice);
            The.Assets.Load (Content);
        }


        protected override void UnloadContent () {}


        protected override void Update (GameTime gameTime) {
            var kbd = Keyboard.GetState ();
            
            if (kbd.IsKeyDown (Keys.Escape)) Exit ();
            if (kbd.IsKeyDown (Keys.P)) The.World.Paused = !The.World.Paused;

            The.World.Update ();
            
            base.Update (gameTime);
        }



        protected override void Draw (GameTime gameTime) {
            GraphicsDevice.Clear (Color.Black);

            _spriteBatch.Begin ();
            The.World.Render();
            _spriteBatch.Draw (The.Assets.SidePanel, new Rectangle (600, 0, 450, 750), Color.White);
            _spriteBatch.End ();

            base.Draw (gameTime);
        }

    }

}
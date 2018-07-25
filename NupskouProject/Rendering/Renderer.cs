using Microsoft.Xna.Framework.Graphics;


namespace NupskouProject.Rendering {

    public class Renderer {

        public Layer Player       = new Layer ();
        public Layer BulletsBack  = new Layer ();
        public Layer Bullets      = new Layer ();
        public Layer BulletsFront = new Layer ();
        public Layer Hitbox       = new Layer ();


        public void Clear () {
            Player.Clear ();
            BulletsBack.Clear ();
            Bullets.Clear ();
            BulletsFront.Clear ();
            Hitbox.Clear ();
        }


        public void Render (SpriteBatch spriteBatch) {
            spriteBatch.Begin ();
            Player.Render (spriteBatch);
            BulletsBack.Render (spriteBatch);
            Bullets.Render (spriteBatch);
            BulletsFront.Render (spriteBatch);
            Hitbox.Render (spriteBatch);
            spriteBatch.End ();
        }

    }


}
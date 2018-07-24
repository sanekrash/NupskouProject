using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;


namespace NupskouProject.Core {

    public class Assets {

        public Texture2D SidePanel;
        public Texture2D RoundBullet;
        public Texture2D PetalBullet;
        public Texture2D BigBullet;
        public Texture2D Rocket;
        public Texture2D Digits;
        public Texture2D Raden;
        public Texture2D Square;
        public Texture2D Arrow;


        public void Load (ContentManager content) {
            SidePanel   = content.Load <Texture2D> ("nupskou-side-panel");
            RoundBullet = content.Load <Texture2D> ("round-bullet");
            PetalBullet = content.Load <Texture2D> ("petal-bullet");
            BigBullet   = content.Load <Texture2D> ("big-bullet");
            Rocket      = content.Load <Texture2D> ("rocket");
            Digits      = content.Load <Texture2D> ("digits");
            Raden       = content.Load <Texture2D> ("raden");
            Square      = content.Load <Texture2D> ("square");
            Arrow       = content.Load<Texture2D>("arrow");
        }

    }

}
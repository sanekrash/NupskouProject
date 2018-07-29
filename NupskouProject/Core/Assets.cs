using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;


namespace NupskouProject.Core {

    public class Assets {

        public Texture2D SidePanel;
        public Texture2D Circle;
        public Texture2D Petal;
        public Texture2D BigBullet;
        public Texture2D Rocket;
        public Texture2D Digits;
        public Texture2D Raden;
        public Texture2D Square;
        public Texture2D Arrow;
        public Texture2D Star;

        public SoundEffect Pjiu;


        public void Load (ContentManager content) {
            SidePanel = content.Load <Texture2D> ("nupskou-side-panel");
            Circle    = content.Load <Texture2D> ("round-bullet");
            Petal     = content.Load <Texture2D> ("petal-bullet");
            BigBullet = content.Load <Texture2D> ("big-bullet");
            Rocket    = content.Load <Texture2D> ("rocket");
            Digits    = content.Load <Texture2D> ("digits");
            Raden     = content.Load <Texture2D> ("raden");
            Square    = content.Load <Texture2D> ("square");
            Arrow     = content.Load <Texture2D> ("arrow");
            Star      = content.Load <Texture2D> ("5star");

            Pjiu = content.Load <SoundEffect> ("pjiu");
        }

    }

}
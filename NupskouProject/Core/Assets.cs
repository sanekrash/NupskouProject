﻿using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;


namespace NupskouProject.Core {

    public class Assets {

        public Texture2D SidePanel;
        public Texture2D RoundBullet;
        public Texture2D PetalBullet;
        public Texture2D Rocket;


        public void Load (ContentManager content) {
            SidePanel   = content.Load <Texture2D> ("nupskou-side-panel");
            RoundBullet = content.Load <Texture2D> ("round-bullet");
            PetalBullet = content.Load <Texture2D> ("petal-bullet");
            Rocket      = content.Load <Texture2D> ("rocket");
        }

    }

}
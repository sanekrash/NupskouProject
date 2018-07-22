using System;
using Microsoft.Xna.Framework.Graphics;


namespace NupskouProject.Core {

    public static class The {

        public static Assets      Assets     = new Assets ();
        public static World       World      = new World ();
        public static Random      Random     = new Random ();
        public static Difficulty  Difficulty = Difficulty.Normal;
        public static SpriteBatch SpriteBatch;

    }

}
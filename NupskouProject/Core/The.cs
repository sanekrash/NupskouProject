using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using NupskouProject.Math;


namespace NupskouProject.Core {

    public static class The {

        public static Assets      Assets     = new Assets ();
        public static World       World      = new World ();
        public static Random      Random     = new Random ();
        public static Difficulty  Difficulty = Difficulty.Lunatic;
        public static SpriteBatch SpriteBatch;
        public static Player Player;

    }

}
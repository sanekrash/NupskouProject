using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using NupskouProject.Math;
using NupskouProject.Rendering;


namespace NupskouProject.Core {

    public static class The {

        public static Assets      Assets     = new Assets ();
        public static World       World      = new World ();
        public static Random      Random     = new Random ();
        public static Renderer    Renderer   = new Renderer ();
        public static Difficulty  Difficulty = Difficulty.Easy;
//        public static SpriteBatch SpriteBatch;
        public static Player Player;

    }

}
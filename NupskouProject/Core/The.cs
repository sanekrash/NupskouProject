using System;
using NupskouProject.Rendering;


namespace NupskouProject.Core {

    public static class The {

        public static Assets      Assets     = new Assets ();
        public static World       World      = new World ();
        public static Random      Random     = new Random ();
        public static Renderer    Renderer   = new Renderer ();
        public static Difficulty  Difficulty = Difficulty.Normal;
//        public static SpriteBatch SpriteBatch;

        public static Player Player;

    }

}
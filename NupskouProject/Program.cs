﻿using System;


namespace NupskouProject {

    public static class Program {

        [STAThread]
        private static void Main () {
            using (var game = new MainGame ()) {
                game.Run ();
            }
        }

    }

}
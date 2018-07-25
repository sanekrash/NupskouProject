using Microsoft.Xna.Framework;
using NupskouProject.Core;
using NupskouProject.Raden.Enemies;


namespace NupskouProject.Stages {

    public class Stage1 : Entity {

        private int _t0;


        public override void OnSpawn () {
            _t0 = The.World.Time;
        }


        public override void Update () {
            int t = The.World.Time - _t0;
            if (t == 60) {
                The.World.Spawn (new Ufo (Color.Red));
            }
            if (t == 120) {
                The.World.Spawn (new Ufo (Color.Red));
            }
            if (t == 180) {
                The.World.Spawn (new Ufo (Color.Red));
            }
        }

    }

}
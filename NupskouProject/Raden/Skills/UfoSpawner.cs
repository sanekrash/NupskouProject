using Microsoft.Xna.Framework;
using NupskouProject.Core;
using NupskouProject.Raden.Enemies;


namespace NupskouProject.Raden.Skills {

    public class UfoSpawner : Entity {

        private int _t0;

        public override void OnSpawn () { _t0 = The.World.Time; }


        public override void Update () {
            int t = The.World.Time - _t0;
            if (t % 60 == 0) {
                The.World.Spawn (new Ufo (Color.Red));
            }
        }

    }

}
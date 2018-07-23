using Microsoft.Xna.Framework;
using NupskouProject.Core;
using NupskouProject.Math;
using NupskouProject.Raden.Bullets;


namespace NupskouProject.Raden.Skills {

    public class Recursion : Entity {

        private XY  _p;
        private int _t0;


        public Recursion (XY p) { _p = p; }

        public override void OnSpawn () { _t0 = The.World.Time; }


        public override void Update () {
            int t = (The.World.Time - _t0);
            if (t % 300 == 0) {
                foreach (var v in Danmaku.Ring (XY.Up, 6)) {
                    The.World.Spawn (new RecursiveBullet (_p, v, Color.Lime, 5));
                }
            }
        }

    }

}
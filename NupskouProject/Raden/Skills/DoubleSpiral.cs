using Microsoft.Xna.Framework;
using NupskouProject.Bullets;
using NupskouProject.Core;
using NupskouProject.Math;


namespace NupskouProject.Raden.Skills {

    public class DoubleSpiral : Entity {

        private XY  _p;
        private int _t0;


        public DoubleSpiral (XY p) { _p = p; }


        public override void OnSpawn () {
            _t0 = The.World.Time;
        }


        public override void Update () {
            var world = The.World;
            int t     = world.Time - _t0;
            if (t % 4 == 0) {
                foreach (var v in Danmaku.Ring (new XY(0.005f * t), 2)) {
                    world.Spawn (new PetalBullet (_p, v,  Color.Lime));
                }
                foreach (var v in Danmaku.Ring (new XY(-0.05f * t), 2)) {
                    world.Spawn (new PetalBullet (_p, v,  Color.Cyan));
                }
            }
        }

    }

}
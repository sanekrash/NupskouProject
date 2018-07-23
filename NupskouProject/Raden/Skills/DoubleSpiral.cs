using Microsoft.Xna.Framework;
using NupskouProject.Core;
using NupskouProject.Math;
using NupskouProject.Raden.Bullets;


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
            if (t % 2 == 0) {
                t /= 2;
                world.Spawn (new PetalBullet (_p, new XY (0.02f * t),  Color.Lime));
                world.Spawn (new PetalBullet (_p, -new XY (0.02f * t), Color.Lime));
                world.Spawn (new PetalBullet (_p, new XY (0.1f * t),  Color.Cyan));
                world.Spawn (new PetalBullet (_p, -new XY (0.1f * t), Color.Cyan));
                world.Spawn (new PetalBullet (_p, new XY (Mathf.phiAngle * t), Color.Pink));
            }
//            if ((The.World.Time - _t0) % 60 == 0) {
//            world.Spawn (new ExplosiveRocket (_p, 2,    The.PlayerXY,                      Color.Lime));
//            world.Spawn (new ExplosiveRocket (_p, 1.5f, XY.Lerp (_p, The.PlayerXY, 0.75f), Color.Lime));
//            }
        }

    }

}
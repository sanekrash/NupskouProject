using Microsoft.Xna.Framework;
using NupskouProject.Bullets;
using NupskouProject.Core;
using NupskouProject.Math;
using NupskouProject.Raden.Bullets;


namespace NupskouProject.Raden.Skills {

    public class Sunflower : Entity {

        private readonly XY  _p;
        private          int _t0;

        public Sunflower (XY p) { _p = p; }

        public override void OnSpawn () { _t0 = The.World.Time; }


        public override void Update () {
            var world = The.World;
            int t     = world.Time - _t0;
            if (t == 30) {
                foreach (var v in Danmaku.Ring (new XY(0, 2), 12)) {
                    world.Spawn (new SunflowerRay (_p, v));
                }
                foreach (var v in Danmaku.Ring (new XY(0, 2.5f).Rotated (Mathf.PI / 12), 12)) {
                    world.Spawn (new SunflowerRay (_p, v));
                }
            }
            if (t >= 180) {
                Despawn ();
                return;
            }
            world.Spawn (new PetalBullet (_p, new XY (t * Mathf.phiAngle), Color.Orange));
        }

    }

}
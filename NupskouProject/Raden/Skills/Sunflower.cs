using Microsoft.Xna.Framework;
using NupskouProject.Bullets;
using NupskouProject.Core;
using NupskouProject.Math;
using NupskouProject.Raden.Bullets;
using NupskouProject.Utils;


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
                var v = new XY (The.Random.Angle ());
                foreach (var w in Danmaku.Ring (4 * v, 12)) {
                    world.Spawn (new SunflowerRay (_p, w));
                }
                foreach (var w in Danmaku.Ring (5 * v.Rotated (Mathf.PI / 12), 12)) {
                    world.Spawn (new SunflowerRay (_p, w));
                }
            }
            if (t >= 180) {
                Despawn ();
                return;
            }
            world.Spawn (new PetalBullet (_p, 2 * new XY (t * Mathf.phiAngle), Color.Orange));
        }

    }

}
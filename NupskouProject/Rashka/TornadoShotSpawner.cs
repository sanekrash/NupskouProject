using Microsoft.Xna.Framework;
using NupskouProject.Core;
using NupskouProject.Math;
using NupskouProject.Rashka.Bullets;


namespace NupskouProject.Rashka {

    public class TornadoShotSpawner : Entity {

        private XY  _p;
        private int _t0;


        public TornadoShotSpawner (XY p) {
            _p = p;
        }


        public override void OnSpawn () {
            _t0 = The.World.Time;
        }


        public override void Update () {
            int t = The.World.Time - _t0;
            if (t % 90 == 0) {
                t /= 90;
                const float angle = Mathf.phiAngle / 15;
                foreach (var v in Danmaku.Ring (new XY (t * angle), 21)) {
                    The.World.Spawn (new BounceArrow (_p, 3*v, Color.Blue));
                }
            }

        }

    }

}
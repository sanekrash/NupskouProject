using Microsoft.Xna.Framework;
using NupskouProject.Core;
using NupskouProject.Math;
using NupskouProject.Raden.Bullets;

namespace NupskouProject.Rashka {

    public class TornadoShotSpawner : Entity {

        private XY  _p;
        private int _t0;


        public TornadoShotSpawner (XY p) { _p = p; }


        public override void OnSpawn () {
            _t0 = The.World.Time;
        }


        public override void Update () {
            if ((The.World.Time - _t0) % 60 == 0) {
                foreach (var v in Danmaku.Ring(new XY(The.Random.Next(360)), 15))
                    The.World.Spawn (new Bullet (_p, v, Color.Red));
            }
        }

    }

}
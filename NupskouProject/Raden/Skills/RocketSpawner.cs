using Microsoft.Xna.Framework;
using NupskouProject.Core;
using NupskouProject.Math;
using NupskouProject.Raden.Bullets;


namespace NupskouProject.Raden.Skills {

    public class RocketSpawner : Entity {

        private XY  _p;
        private int _t0;


        public RocketSpawner (XY p) { _p = p; }


        public override void OnSpawn () {
            _t0 = The.World.Time;
        }


        public override void Update () {
            if ((The.World.Time - _t0) % 60 == 0) {
                The.World.Spawn (new ExplosiveRocket (_p, 2,    The.PlayerXY,                      Color.Lime));
                The.World.Spawn (new ExplosiveRocket (_p, 1.5f, XY.Lerp (_p, The.PlayerXY, 0.75f), Color.Lime));
            }
        }

    }

}
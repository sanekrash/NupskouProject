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
            if ((The.World.Time - _t0) % 180 == 0) {
                The.World.Spawn (new ExplosiveRocket (_p, 4, The.Player.Position,                      Color.Lime));
                The.World.Spawn (new ExplosiveRocket (_p, 3, XY.Lerp (_p, The.Player.Position, 0.75f), Color.Lime));
                The.World.Spawn (new ExplosiveRocket (_p, 2, XY.Lerp (_p, The.Player.Position, 0.5f),  Color.Lime));
            }
        }

    }

}
using Microsoft.Xna.Framework;
using NupskouProject.Core;
using NupskouProject.Math;
using NupskouProject.Rashka.Bullets;

namespace NupskouProject.Rashka
{
    public class ShootTheLalkaSpawner : Entity
    {
        private XY  _p;
        private int _t0;


        public ShootTheLalkaSpawner (XY p) {
            _p = p;
        }


        public override void OnSpawn () {
            _t0 = The.World.Time;
        }


        public override void Update () {
            int t = The.World.Time - _t0;


        }

    }
}

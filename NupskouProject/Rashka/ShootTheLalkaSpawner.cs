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
            var   world = The.World;
            int   t     = world.Time - _t0;
            if (t % 60 == 0){
            world.Spawn (new RayCast (new XY(The.Player.Position.X,0), Mathf.PI/2, 3, Color.Purple));
            world.Spawn (new RayCast (new XY(0,The.Player.Position.Y), 0, 3 ,Color.Purple));
            
                }

        }

    }
}

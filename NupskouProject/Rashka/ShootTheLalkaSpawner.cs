using Microsoft.Xna.Framework;
using NupskouProject.Core;
using NupskouProject.Entities;
using NupskouProject.Math;
using NupskouProject.Rashka.Bullets;
using NupskouProject.Utils;

namespace NupskouProject.Rashka
{
    public class ShootTheLalkaSpawner : Entity
    {
        private XY  _p;
        private int _t0;
        private int _w;


        public ShootTheLalkaSpawner (XY p) {
            _p = p;
        }
        


        public override void OnSpawn () {
            _t0 = The.World.Time;
        }


        public override void Update () {
            var   world = The.World;
            int   t     = world.Time - _t0;
                if (t % 15 == 0) {
                SpawnDanmaku ();
            }
            if (t % 120 == 0){
            world.Spawn (new MarkRayTrigger (new XY(The.Player.Position.X,0), Mathf.PI/2, 60, Color.Purple));
            world.Spawn (new MarkRayTrigger (new XY(0,The.Player.Position.Y), 0, 60 ,Color.Purple));
            
                }

        }

        private static void SpawnDanmaku()
        {
            for (int i = 0; i < 4; i++)
            {
                The.World.Spawn(new Bullet(new XY(The.Random.Float(World.Box.Right, World.Box.Left),0), XY.Down,
                    Color.Red));
            }
        }

    }
}

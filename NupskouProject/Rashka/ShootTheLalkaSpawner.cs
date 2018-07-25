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
            if (t % 60 == 0){
            world.Spawn (new MarkRay (new XY(The.Player.Position.X,0), Mathf.PI/2, 30, Color.Purple));
            world.Spawn (new MarkRay (new XY(0,The.Player.Position.Y), 0, 30 ,Color.Purple));
            
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

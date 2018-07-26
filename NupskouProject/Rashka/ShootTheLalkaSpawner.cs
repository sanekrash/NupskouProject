using System.Diagnostics;
using System.Threading;
using Microsoft.Xna.Framework;
using NupskouProject.Core;
using NupskouProject.Entities;
using NupskouProject.Math;
using NupskouProject.Raden.Utils;
using NupskouProject.Rashka.Bullets;
using NupskouProject.Utils;


namespace NupskouProject.Rashka {

    public class ShootTheLalkaSpawner : Entity {

        private XY  _p;
        private int _w = The.Difficulty.Choose (30, 30, 45, 60);
        private int _danmakuInterval = The.Difficulty.Choose (45, 30, 20, 15);
        private int _danmakuInterval1 = The.Difficulty.Choose (18, 12, 9, 6);

        private float _cone = The.Difficulty.Choose (Mathf.PI/24 , Mathf.PI/24, Mathf.PI/12, Mathf.PI/12);

        


        public ShootTheLalkaSpawner (XY p) {
            _p = p;
        }


        public override void Update (int t) {
            var world = The.World;
            if (t % _danmakuInterval == 0) {
                SpawnDanmaku ();
            }
            if (t % 180 == 0 && t != 0) {
                world.Spawn (
                    new MarkRayTrigger (
                        new XY (The.Player.Position.X, 0),
                        Mathf.PI / 2,
                        _w,
                        Color.LimeGreen
                    )
                );
                world.Spawn (
                    new MarkRayTrigger (
                        new XY (0, The.Player.Position.Y),
                        0,
                        _w,
                        Color.LimeGreen
                    )
                );
            }

            if (t % 360 < 90 && t % _danmakuInterval1 == 0 && !(t <= 90))
            {
                The.World.Spawn(new MarkRayTrigger(_p,
                    XY.DirectionAngle(_p, The.Player.Position) + The.Random.Float(-_cone, _cone), _w/2f,
                    Color.Red));
            }
        }


        private void SpawnDanmaku () {
            for (int i = 0; i < 4; i++) {
                The.World.Spawn (
                    new Bullet (
                        new XY (The.Random.Float (World.Box.Right, World.Box.Left), 0),
                        XY.Down,
                        Color.Red
                    )
                );
            }
        }
        


        


    }

}
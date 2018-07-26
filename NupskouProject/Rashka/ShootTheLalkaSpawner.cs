using System.Diagnostics;
using System.Text;
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

        private int _w = The.Difficulty.Choose (30, 30, 30, 45);
        private int _danmakuInterval = The.Difficulty.Choose (25, 15, 15, 15);
        private int _danmakuInterval1 = The.Difficulty.Choose (180, 180, 180, 120);

        private float _cone = The.Difficulty.Choose (Mathf.PI/24 , Mathf.PI/18, Mathf.PI/12, Mathf.PI/9);


        public override void Update (int t) {
            var world = The.World;
            if (t % _danmakuInterval == 0) {
                SpawnDanmaku ();
            }
            if (t % _danmakuInterval1 == 0 && t != 0) {
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
                if (The.Difficulty >= Difficulty.Hard) {
                                    world.Spawn (
                    new MarkRayTrigger (
                        new XY (0, The.Player.Position.Y-The.Player.Position.X),
                        Mathf.PI / 4,
                        _w,
                        Color.LimeGreen
                    )
                );
                    world.Spawn (
                        new MarkRayTrigger (
                            new XY (0, The.Player.Position.Y+The.Player.Position.X),
                            - Mathf.PI / 4,
                            _w,
                            Color.LimeGreen
                        )
                    );
                    }
            }

            /*if (t % 360 < 90 && t % _danmakuInterval1 == 0 && !(t <= 90))
            {
                if (The.Difficulty <= Difficulty.Easy) {
                    The.World.Spawn(new MarkRayTrigger(_p,
                        XY.DirectionAngle(_p, The.Player.Position) + The.Random.Float(-_cone, _cone), _w / 2f,
                        Color.Red));
                }
                if (The.Difficulty >= Difficulty.Normal) {
                        The.World.Spawn(new MarkRayTrigger(_p,
                            XY.DirectionAngle(_p, The.Player.Position) , _w / 2f,
                            Color.Red));
                     The.World.Spawn(new MarkRayTrigger(_p,
                         XY.DirectionAngle(_p, The.Player.Position) + The.Random.Float(-_cone, 0), _w / 2f,
                         Color.Red));
                     The.World.Spawn(new MarkRayTrigger(_p,
                         XY.DirectionAngle(_p, The.Player.Position) + The.Random.Float(0, _cone), _w / 2f,
                         Color.Red));
                    if (The.Difficulty >= Difficulty.Lunatic)
                    {
                        The.World.Spawn(new MarkRayTrigger(_p,
                            XY.DirectionAngle(_p, The.Player.Position) + The.Random.Float(-_cone*2f, 0-_cone), _w / 2f,
                            Color.Red));
                        The.World.Spawn(new MarkRayTrigger(_p,
                            XY.DirectionAngle(_p, The.Player.Position) + The.Random.Float(-_cone, _cone*2f), _w / 2f,
                            Color.Red));
                    }

                }
                
            
        }*/
            }


        private void SpawnDanmaku () {
            for (int i = 0; i < 4; i++) {
                The.World.Spawn (
                    new Bullet (
                        new XY (The.Random.Float (World.Box.Right, World.Box.Left), 0),
                         new XY (Mathf.PI/2 + The.Random.Float(-_cone,_cone)),
                        Color.Red
                    )
                );
            }
        }
        


        


    }

}
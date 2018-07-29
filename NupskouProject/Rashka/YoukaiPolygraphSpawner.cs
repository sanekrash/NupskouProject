using System;
using Microsoft.Xna.Framework;
using NupskouProject.Core;
using NupskouProject.Entities;
using NupskouProject.Math;
using NupskouProject.Rashka.Bullets;
using NupskouProject.Utils;

namespace NupskouProject.Rashka
{
    public class YoukaiPolygraphSpawner: Entity
    {
        private XY  _p;
        private float _angle = 0;
        private float _danmakuInterval = 720;
        private float _r;
        public YoukaiPolygraphSpawner (XY p) {
            _p = p;
        }


        public override void Update(int t)
        {
            var world = The.World;
            _r = XY.Distance(_p, The.Player.Position);
            world.Spawn(
                new DeathRay(
                    _p,
                    0 + Mathf.PI / _danmakuInterval * t,
                    3,
                    Color.Red
                )
            );
            world.Spawn(
                new DeathRay(
                    _p, 
                    Mathf.PI / 3 + Mathf.PI/_danmakuInterval * t,
                    3,
                    Color.Purple
                )
            );
            world.Spawn(
                new DeathRay(
                    _p, 
                    2 * Mathf.PI / 3 + Mathf.PI/_danmakuInterval * t,
                    3,
                    Color.Red
                )
            );
            world.Spawn(
                new DeathRay(
                    _p, 
                    Mathf.PI + Mathf.PI/_danmakuInterval * t,
                    3,
                    Color.Purple
                )
            );
            world.Spawn(
                new DeathRay(
                    _p, 
                    - Mathf.PI / 3 + Mathf.PI/_danmakuInterval * t,
                    3,
                    Color.Purple
                )
            );
            world.Spawn(
                new DeathRay(
                    _p, 
                    - 2 * Mathf.PI / 3 + Mathf.PI/_danmakuInterval * t,
                    3,
                    Color.Red
                )
            );
            world.Spawn(
                new DeathRay(
                    _p, 
                    - Mathf.PI + Mathf.PI/_danmakuInterval * t,
                    3,
                    Color.Purple
                )
            );
            if (t % 5 == 0)
            {
                The.World.Spawn(
                    new PetalBullet(
                        new XY(_p.X+ Mathf.Cos(0) *_r, _p.Y+ Mathf.Sin(0)*_r),
                        new XY(0,0),
                        Color.Red
                    )
                );
            }
        }
    }
}
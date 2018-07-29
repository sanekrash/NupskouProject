using System;
using System.Runtime.InteropServices;
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
        private float _angle;
        private float _danmakuInterval = 720;
        private float _r;
        
        public YoukaiPolygraphSpawner (XY p) {
            _p = p;
        }


        public override void Update(int t)
        {
            var world = The.World;
            _angle = XY.DirectionAngle(_p, The.Player.Position);
            _r = XY.Distance(_p, The.Player.Position);
            for (int i = 0; i < 6; i++)
            {
                world.Spawn(
                    new DeathRay(
                        _p,
                        0 + Mathf.PI / _danmakuInterval * t + Mathf.PI / 3 * i,
                        3,
                        Color.Red
                    )
                );
            }
            if (t % 6 == 0)
            {
                for (int i = 0; i < 6; i++)
                {
                    The.World.Spawn(
                        new FadePetalBullet(
                            new XY(_p.X+ Mathf.Cos(Mathf.PI/_danmakuInterval * t + i * Mathf.PI/3) *_r, _p.Y+ Mathf.Sin(Mathf.PI/_danmakuInterval * t + i * Mathf.PI/3)*_r),
                            XY.DirectionAngle(_p,new XY(_p.X+ Mathf.Cos(Mathf.PI/_danmakuInterval * t + i * Mathf.PI/3) *_r, _p.Y+ Mathf.Sin(Mathf.PI/_danmakuInterval * t + i * Mathf.PI/3)*_r)),
                            Color.Red,
                            (Mathf.PI/3) / (Mathf.PI / _danmakuInterval)
                        )
                    );
                }

            }
        }
    }
}
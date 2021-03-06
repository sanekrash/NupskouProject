﻿using Microsoft.Xna.Framework;
using NupskouProject.Core;
using NupskouProject.Entities;
using NupskouProject.Math;
using NupskouProject.Raden.Bullets;
using NupskouProject.Utils;


namespace NupskouProject.Raden.Skills {

    public class Sunflower : Entity {

        private readonly XY  _p;

        public Sunflower (XY p) { _p = p; }


        public override void Update (int t) {
            var world = The.World;
            if (t % 60 == 0) {
                var v = new XY (The.Random.Angle ());
                foreach (var w in Danmaku.Ring (4 * v, 24)) {
                    world.Spawn (new SunflowerRay (_p, w));
                }
//                foreach (var w in Danmaku.Ring (5 * v.Rotated (Mathf.PI / 12), 12)) {
//                    world.Spawn (new SunflowerRay (_p, w));
//                }
            }
            if (t >= 120) {
                Despawn ();
                return;
            }
            foreach (var v in Danmaku.Ring (2 * new XY (t * Mathf.phiAngle / 2), 2)) {
                world.Spawn (new PetalBullet (_p, v, Color.Orange));
            }
        }

    }

}
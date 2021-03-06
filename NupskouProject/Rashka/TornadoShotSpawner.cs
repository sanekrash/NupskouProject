﻿using Microsoft.Xna.Framework;
using NupskouProject.Core;
using NupskouProject.Math;
using NupskouProject.Rashka.Bullets;


namespace NupskouProject.Rashka {

    public class TornadoShotSpawner : Entity {

        private XY  _p;
        private int _t0;


        public TornadoShotSpawner (XY p) {
            _p = p;
        }


        public override void OnSpawn () {
            _t0 = The.World.Time;
        }


        public override void Update (int t) {
            if (t % 90 == 0) {
                t /= 90;
                float angle = Mathf.phiAngle + (1.24f*t);
                foreach (var v in Danmaku.Ring (new XY (t * angle), 21)) {
                    The.World.Spawn (new BounceArrow (_p, 4*v, Color.Blue));
                }
            }

        }

    }

}
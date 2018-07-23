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


        public override void Update () {
            int t = The.World.Time - _t0;
            if (t % 60 == 0) {
                t /= 60;
                const float angle = Mathf.phiAngle / 15;
                foreach (var v in Danmaku.Ring (new XY (t * angle), 15)) {
                    The.World.Spawn (new BounceArrow (_p, 3*v, Color.Blue));
                }
            }

        }

    }

}
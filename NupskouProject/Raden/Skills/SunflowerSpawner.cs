﻿using System;
using NupskouProject.Core;
using NupskouProject.Math;
using NupskouProject.Utils;


namespace NupskouProject.Raden.Skills {

    public class SunflowerSpawner : Entity {

        private int _t0;
        private XY  _prevSpawn = World.PlayerPlace;


        private static readonly Box spawnBox = new Box (
            Mathf.LerpUnclamped (World.Box.Left, World.Box.Right,  0.2f),
            Mathf.LerpUnclamped (World.Box.Top,  World.Box.Bottom, 0.1f),
            Mathf.LerpUnclamped (World.Box.Left, World.Box.Right,  0.8f),
            Mathf.LerpUnclamped (World.Box.Top,  World.Box.Bottom, 0.5f)
        );


        public override void OnSpawn () { _t0 = The.World.Time; }


        public override void Update () {
            int t        = The.World.Time - _t0;
            var worldBox = World.Box;
            var random   = The.Random;

            int interval;
            switch (The.Difficulty) {
                case Difficulty.Easy:
                    interval = 180;
                    break;
                case Difficulty.Normal:
                    interval = 120;
                    break;
                case Difficulty.Hard:
                    interval = 90;
                    break;
                case Difficulty.Lunatic:
                    interval = 60;
                    break;
                default: throw new ArgumentOutOfRangeException ();
            }

            if (t % interval == 0) {
                var a = The.Random.Point (spawnBox);
                var b = The.Random.Point (spawnBox);
                _prevSpawn = XY.SqrDistance (a, _prevSpawn) > XY.SqrDistance (b, _prevSpawn) ? a : b;
                The.World.Spawn (new Sunflower (_prevSpawn));
            }
        }

    }


}
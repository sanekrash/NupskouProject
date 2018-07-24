using System;
using Microsoft.Xna.Framework;
using NupskouProject.Core;
using NupskouProject.Math;
using NupskouProject.Raden.Bullets;


namespace NupskouProject.Raden.Skills {

    public class Recursion : Entity {

        private XY  _p;
        private int _t0;


        public Recursion (XY p) { _p = p; }

        public override void OnSpawn () { _t0 = The.World.Time; }


        public override void Update () {
            int   t = (The.World.Time - _t0);
            Color color;
            switch (t % 1800) {
                case 0:
                    color = Color.Lime;
                    break;
                case 300:
                    color = Color.Yellow;
                    break;
                case 600:
                    color = Color.Red;
                    break;
                case 900:
                    color = Color.Magenta;
                    break;
                case 1200:
                    color = Color.Blue;
                    break;
                case 1500:
                    color = Color.Cyan;
                    break;
                default: return;
            }
            XY v;
            switch (t % 1200) {
                case 0:
                    v = XY.Down;
                    break;
                case 300:
                    v = XY.Left;
                    break;
                case 600:
                    v = XY.Up;
                    break;
                case 900:
                    v = XY.Right;
                    break;
                default: return;
            }
            int bullets = 11;
            switch (The.Difficulty) {
                case Difficulty.Easy:
                    bullets = 5;
                    break;
                case Difficulty.Normal:
                    bullets = 7;
                    break;
                case Difficulty.Hard:
                    bullets = 9;
                    break;
            }
            
            foreach (var w in Danmaku.Ring (v, bullets)) {
                The.World.Spawn (new RecursiveBullet (_p, w, color, 5));
            }
        }

    }

}
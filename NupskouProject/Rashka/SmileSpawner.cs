using System;
using System.Linq.Expressions;
using Microsoft.Xna.Framework;
using NupskouProject.Core;
using NupskouProject.Entities;
using NupskouProject.Math;
using NupskouProject.Raden.Enemies;
using NupskouProject.Rashka.Bullets;
using NupskouProject.Utils;


namespace NupskouProject.Rashka {

    public class SmileSpawner : Entity {

        public override void Update (int t) {
            if (t % 30 == 0) {
                var box = World.Box;
                SpawnSmile (
                    new XY (The.Random.Float (box.Left , box.Right/2), -100),
                    5 * new XY (The.Random.SignedFloat () * Mathf.PI / 1.5f).Rotated90CCW (),
                    Color.Red
                    );
                SpawnSmile(
                    new XY(The.Random.Float(box.Left/2, box.Right ), -100),
                    5 * new XY(The.Random.SignedFloat() * Mathf.PI / 1.5f).Rotated90CCW(),
                    Color.Red
                );

            }
        }


        private void SpawnSmile (XY p, XY v, Color color) {
            var w     = v.Normalized;
            var line  = Danmaku.Line (w, 0, 40, 5);
            var spray = Danmaku.Spray (90 * w, Mathf.PI / 3, 9);

            var world = The.World;
            foreach (var offset in line) {
                world.Spawn (new VerticalBounceBullet (p + 20 * w.Rotated90CW () + offset, v, color));
                world.Spawn (new VerticalBounceBullet (p - 20 * w.Rotated90CW () + offset, v, color));
            }
            foreach (var offset in spray) {
                world.Spawn (new VerticalBounceBullet (p + offset, v, color));
            }
        }

    }

}
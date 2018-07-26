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
                SpawnSmile (World.BossPlace, 4 * new XY(The.Random.Angle ()));
            }
        }


        private void SpawnSmile (XY p, XY v) {
            var w     = v.Normalized;
            var line  = Danmaku.Line (w, 0, 40, 5);
            var spray = Danmaku.Spray (90 * w, Mathf.PI / 3, 9);

            var world = The.World;
            foreach (var offset in line) {
                world.Spawn (new Bullet (p + 20 * w.Rotated90CW () + offset, v, Color.Red));
                world.Spawn (new Bullet (p - 20 * w.Rotated90CW () + offset, v, Color.Red));
            }
            foreach (var offset in spray) {
                world.Spawn (new Bullet (p + offset, v, Color.Red));
            }
        }

    }

}
using System;
using Microsoft.Xna.Framework;
using NupskouProject.Core;
using NupskouProject.Math;
using NupskouProject.Raden.Bullets;
using NupskouProject.Utils;


namespace NupskouProject.Raden.Skills {

    public class RocketSpawner : Entity {

        private XY _p;


        public RocketSpawner (XY p) { _p = p; }


        public override void Update (int t) {
            if (t % 180 == 0) {
                if (The.Difficulty >= Difficulty.Lunatic) {
                    FireEpicSalvo (The.Player.Position);
                } else {
                    FireSalvo (The.Player.Position);
                }
                if (The.Difficulty >= Difficulty.Normal) {
                    FireRocket (XY.Lerp (_p, The.Player.Position, -0.5f));
                }
                return;
            }
            if (t % 60 == 0 && The.Difficulty >= Difficulty.Hard) {
                FireRocket (The.Player.Position);
            }
        }


        private void FireRocket (XY target) {
            The.World.Spawn (
                new ExplosiveRocket (
                    _p,
                    Mathf.CeilToInt ((The.Player.Position - _p).Length / 3),
                    target,
                    Color.Lime
                )
            );
        }


        private void FireSalvo (XY target) {
            var world = The.World;
            var x     = target - _p;
            var y     = x.Rotated90CW () / Mathf.Sqrt (3);

            int fuse = Mathf.CeilToInt ((The.Player.Position - _p).Length / 3);

            world.Spawn (new ExplosiveRocket (_p, fuse, target,                     Color.Lime));
            world.Spawn (new ExplosiveRocket (_p, fuse, _p + 0.75f * x + 0.25f * y, Color.Lime));
            world.Spawn (new ExplosiveRocket (_p, fuse, _p + 0.75f * x - 0.25f * y, Color.Lime));
        }


        private void FireEpicSalvo (XY target) {
            var world = The.World;
            var x     = target - _p;
            var y     = x.Rotated90CW () / Mathf.Sqrt (3);

            int fuse = Mathf.CeilToInt ((The.Player.Position - _p).Length / 3);

            world.Spawn (new ExplosiveRocket (_p, fuse, target,                     Color.Lime));
            world.Spawn (new ExplosiveRocket (_p, fuse, _p + 0.75f * x + 0.25f * y, Color.Lime));
            world.Spawn (new ExplosiveRocket (_p, fuse, _p + 0.75f * x - 0.25f * y, Color.Lime));
            world.Spawn (new ExplosiveRocket (_p, fuse, _p + 0.5f * x,              Color.Lime));
            world.Spawn (new ExplosiveRocket (_p, fuse, _p + 0.5f * x + 0.5f * y,   Color.Lime));
            world.Spawn (new ExplosiveRocket (_p, fuse, _p + 0.5f * x - 0.5f * y,   Color.Lime));
        }


    }

}
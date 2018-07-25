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
            if (t % 180 != 0) return;

            var world = The.World;

            int n = The.Difficulty.Choose (3, 4, 6, 6);
            for (int i = n; i > 1; i--) {
                float coeff = i / (float) n;
                var target = XY.Lerp (_p, The.Player.Position, coeff);
                world.Spawn (new ExplosiveRocket (_p, 4 * coeff, target, Color.Lime));
            }
        }

    }

}
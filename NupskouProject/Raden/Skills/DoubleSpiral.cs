using Microsoft.Xna.Framework;
using NupskouProject.Core;
using NupskouProject.Entities;
using NupskouProject.Math;
using NupskouProject.Utils;


namespace NupskouProject.Raden.Skills {

    public class DoubleSpiral : Entity {

        private XY _p;


        public DoubleSpiral (XY p) { _p = p; }


        public override void Update (int t) {
            var world    = The.World;
            int interval = The.Difficulty <= Difficulty.Easy ? 12 : 2;
            int rays     = The.Difficulty.Choose (2, 2, 3, 5);
            if (t % interval == 0) {
                foreach (var v in Danmaku.Ring (new XY (0.004f * t), rays)) {
                    world.Spawn (new PetalBullet (_p, v, Color.Lime));
                }
            }
            if (t % 4 == 0) {
                foreach (var v in Danmaku.Ring (new XY (-0.1f / rays * t), rays)) {
                    world.Spawn (new PetalBullet (_p, v, Color.Cyan));
                }
            }
        }

    }

}
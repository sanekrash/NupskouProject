using Microsoft.Xna.Framework;
using NupskouProject.Core;
using NupskouProject.Entities;
using NupskouProject.Math;


namespace NupskouProject.Raden.Skills {

    public class DoubleSpiral : Entity {

        private XY _p;


        public DoubleSpiral (XY p) { _p = p; }


        public override void Update (int t) {
            var world    = The.World;
            int interval = The.Difficulty <= Difficulty.Easy ? 8 : 2;
            if (t % interval == 0) {
                foreach (var v in Danmaku.Ring (new XY (0.005f * t), 2)) {
                    world.Spawn (new PetalBullet (_p, v, Color.Lime));
                }
            }
            if (t % 4 == 0) {
                foreach (var v in Danmaku.Ring (new XY (-0.2f / 4 * t), 2)) {
                    world.Spawn (new PetalBullet (_p, v, Color.Cyan));
                }
            }
        }

    }

}
using Microsoft.Xna.Framework;
using NupskouProject.Core;
using NupskouProject.Math;
using NupskouProject.Rashka.Bullets;

namespace NupskouProject.Rashka.Nonspells
{
    public class MultipleShotSpraySpawner : Entity
    {
        private XY  _p;
        public MultipleShotSpraySpawner (XY p) {
            _p = p;
        }

        public override void Update(int t)
        {
            var world = The.World;
            if (t % 60 == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    foreach (var v in Danmaku.Spray(new XY(XY.DirectionAngle(_p, The.Player.Position)), Mathf.PI, 36))
                {
                    world.Spawn(new Arrow(_p, (2 + i*0.5f) * v, Color.Red));
                }
                }
            }
        }
    }
}
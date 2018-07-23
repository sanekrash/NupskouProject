using Microsoft.Xna.Framework;
using NupskouProject.Core;
using NupskouProject.Math;
using NupskouProject.Rashka.Bullets;

namespace NupskouProject.Rashka
{

    public class TornadoShotSpawner : Entity
    {

        private XY _p;
        private int _t0;


        public TornadoShotSpawner(XY p)
        {
            _p = p;
        }


        public override void OnSpawn()
        {
            _t0 = The.World.Time;
        }


        public override void Update()
        {
            if ((The.World.Time - _t0) % 60 == 0)
            {
                foreach (var v in Danmaku.Ring(new XY(_t0), 15 + The.Random.Next(5)))
                {
                    The.World.Spawn(new BounceArrow(_p, v, Color.Blue));
                }
            }

        }

    }
}
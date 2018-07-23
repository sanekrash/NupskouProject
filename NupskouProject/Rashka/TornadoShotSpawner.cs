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
        private float _angle;

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
                _angle = (float) (The.World.Time - _t0); // 222/180 = 1,24
                foreach (var v in Danmaku.Ring(new XY(_angle) , 15))
                {
                    The.World.Spawn(new BounceArrow(_p, v, Color.Blue));
                }
            }

        }

    }
}
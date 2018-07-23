using Microsoft.Xna.Framework;
using NupskouProject.Bullets;
using NupskouProject.Core;
using NupskouProject.Math;
using NupskouProject.Utils;


namespace NupskouProject.Rashka.Bullets {

    public class BounceArrow : Entity {

        private readonly XY    _p0;
        private readonly XY    _v;
        private readonly Color _color;

        private int _t0;
        private XY  _p;


        public BounceArrow (XY p0, XY v, Color color) {
            _p     = _p0 = p0;
            _v     = v;
            _color = color;
        }


        public override void OnSpawn () {
            _t0 = The.World.Time;
        }


        public override void OnDespawn () {
        }


        public override void Update () {
            _p = _p0 + (The.World.Time - _t0) * _v;
            if (!Geom.CircleInBox (new Circle (_p, 6), World.Box)) {
                Despawn ();
                foreach (var v in Danmaku.Spray(-_v , Mathf.PI / 3 , 3) ) {
                    The.World.Spawn (new Bullet(_p, v/3, Color.Red)) ;
                }

            }
        }


        public override void Render () {
            The.SpriteBatch.DrawCircle (_p, _color,      6);
            The.SpriteBatch.DrawCircle (_p, Color.White, 4);
        }

    }

}
using Microsoft.Xna.Framework;
using NupskouProject.Core;
using NupskouProject.Math;
using NupskouProject.MathUtils;
using NupskouProject.Utils;


namespace NupskouProject.Rashka.Bullets {

    public class BounceBullet : Entity {

        private readonly XY    _p0;
        private readonly XY    _v;
        private readonly Color _color;

        private int _t0;
        private XY  _p;


        public BounceBullet (XY p0, XY v, Color color) {
            _p     = _p0 = p0;
            _v     = v;
            _color = color;
        }


        public override void OnSpawn () {
            _t0 = The.World.Time;
        }


        public override void OnDespawn () {
            The.World.Spawn (new Bullet (_p, -_v, _color));
        }


        public override void Update () {
            _p = _p0 + (The.World.Time - _t0) * _v;
            if (!Geom.CircleInBox (new Circle (_p, 6), World.Box)) {
                Despawn ();
            }
        }


        public override void Render () {
            The.SpriteBatch.DrawCircle (_p, _color,      6);
            The.SpriteBatch.DrawCircle (_p, Color.White, 4);
        }

    }

}
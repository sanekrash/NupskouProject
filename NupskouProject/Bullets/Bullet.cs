using Microsoft.Xna.Framework;
using NupskouProject.Core;
using NupskouProject.Math;
using NupskouProject.Utils;


namespace NupskouProject.Bullets {

    public class Bullet : Entity {

        private readonly XY    _p0;
        private readonly XY    _v;
        private readonly Color _color;

        private int _t0;
        private XY  _p;


        public Bullet (XY p0, XY v, Color color) {
            _p     = _p0 = p0;
            _v     = v;
            _color = color;
        }


        public override void OnSpawn () {
            _t0 = The.World.Time;
        }


        public override void Update () {
            _p = _p0 + (The.World.Time - _t0) * _v;
            if (!Geom.CircleOverBox (new Circle (_p, 6), World.Box)) {
                Despawn ();
            }
        }


        public override void Render () {
            The.SpriteBatch.DrawCircle (_p, _color,      6);
            The.SpriteBatch.DrawCircle (_p, Color.White, 4);
        }

    }

}
using Microsoft.Xna.Framework;
using NupskouProject.Core;
using NupskouProject.Math;


namespace NupskouProject.Entities {

    public class Bullet : Entity {

        private readonly XY    _p0;
        private readonly XY    _v;
        private readonly Color _color;

        private XY  _p;


        public Bullet (XY p0, XY v, Color color) {
            _p     = _p0 = p0;
            _v     = v;
            _color = color;
        }


        public override void Update (int t) {
            _p = _p0 + t * _v;
            if (!Geom.CircleOverBox (new Circle (_p, 6), World.Box)) {
                Despawn ();
            }
        }


        public override void Render () {
            The.Renderer.Bullets.DrawCircle (_p, _color,      6);
            The.Renderer.Bullets.DrawCircle (_p, Color.White, 4);
        }

    }

}
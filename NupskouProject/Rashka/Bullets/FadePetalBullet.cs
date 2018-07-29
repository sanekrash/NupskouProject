using Microsoft.Xna.Framework;
using NupskouProject.Core;
using NupskouProject.Math;


namespace NupskouProject.Entities {

    public class FadePetalBullet : Entity {

        private readonly XY    _p0;
        private readonly XY    _v;
        private readonly float _rotation;
        private readonly Color _color;
        private readonly float _duration;

        private XY _p;


        public FadePetalBullet (XY p0, float rotation, Color color, float duration) {
            _p        = _p0 = p0;
            _rotation = rotation + Mathf.PI/2;
            _color    = color;
            _duration = duration;
        }


        public override void Update (int t) {
            _p = _p0 + t * _v;
            if (!Geom.CircleOverBox (new Circle (_p, 6), World.Box)) {
                Despawn ();
            }
            if (t >= _duration) {
                Despawn ();
            }
        }


        public override void Render () {
            The.Renderer.Bullets.DrawPetal (_p, _rotation, _color,      4);
            The.Renderer.Bullets.DrawPetal (_p, _rotation, Color.White, 2.5f);
        }

    }

}
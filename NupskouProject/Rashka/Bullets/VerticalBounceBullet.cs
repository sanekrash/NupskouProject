using Microsoft.Xna.Framework;
using NupskouProject.Core;
using NupskouProject.Math;
using NupskouProject.Utils;
using OpenGL;


namespace NupskouProject.Rashka.Bullets {

    public class VerticalBounceBullet : Entity {

        private readonly XY    _p0;
        private readonly XY    _v;
        private readonly Color _color;

        private XY _p;


        public VerticalBounceBullet (XY p0, XY v, Color color) {
            _p        = _p0 = p0;
            _v        = v;
            _color    = color;
        }


        public override void Update (int t) {
            _p = _p0 + t * _v;
            _p.X = Mathf.PingPong (_p.X, World.Box.Right);
            if (_p.Y > World.Box.Bottom + 6) {
                Despawn ();
            }
        }


        public override void Render () {
            The.Renderer.Bullets.DrawCircle (_p, _color,      6);
            The.Renderer.Bullets.DrawCircle (_p, Color.White, 4);
        }

    }

}
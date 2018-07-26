using Microsoft.Xna.Framework;
using NupskouProject.Core;
using NupskouProject.Math;


namespace NupskouProject.Entities {

    public class PetalBullet : Entity {

        private readonly XY    _p0;
        private readonly XY    _v;
        private readonly float _rotation;
        private readonly Color _color;

        private XY _p;


        public PetalBullet (XY p0, XY v, Color color) {
            _p        = _p0 = p0;
            _v        = v;
            _color    = color;
            _rotation = _v.Angle;
        }


        public override void Update (int t) {
            _p = _p0 + t * _v;
            if (!Geom.CircleOverBox (new Circle (_p, 6), World.Box)) {
                Despawn ();
            }
        }


        public override void Render () {
            The.Renderer.Bullets.DrawPetal (_p, _rotation, _color,      4);
            The.Renderer.Bullets.DrawPetal (_p, _rotation, Color.White, 2.5f);
//            The.Renderer.BulletsBack.DrawRay (_p, _rotation, _color * 0.1f, 3, 1000);
        }

    }

}
using Microsoft.Xna.Framework;
using NupskouProject.Core;
using NupskouProject.Math;
using NupskouProject.Utils;


namespace NupskouProject.Rashka.Bullets {

    public class Arrow : Entity {

        private readonly XY    _p0;
        private readonly XY    _v;
        private readonly float _rotation;
        private readonly Color _color;

        private XY  _p;
        


        public Arrow (XY p0, XY v, Color color) {
            _p     = _p0 = p0;
            _v     = v;
            _color = color;
            _rotation = _v.Angle;
        }


        public override void Update (int t) {
            _p = _p0 + t * _v;
            if (!Geom.CircleOverBox (new Circle (_p, 6), World.Box)) {
                Despawn ();
            }
        }


        public override void Render () {
            The.Renderer.Bullets.DrawArrow (_p,_rotation , _color,      2);
        }

    }

}
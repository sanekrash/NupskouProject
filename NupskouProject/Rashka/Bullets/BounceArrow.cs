using Microsoft.Xna.Framework;
using NupskouProject.Core;
using NupskouProject.Math;
using NupskouProject.Utils;


namespace NupskouProject.Rashka.Bullets {

    public class BounceArrow : Entity {

        private readonly XY    _p0;
        private readonly XY    _v;
        private readonly float _rotation;
        private readonly Color _color;

        private XY _p;


        public BounceArrow (XY p0, XY v, Color color) {
            _p        = _p0 = p0;
            _v        = v;
            _color    = color;
            _rotation = _v.Angle;
        }


        public override void Update (int t) {
            _p = _p0 + t * _v;
            if (!Geom.CircleInBox (new Circle (_p, 6), World.Box)) {
                Explode ();
            }
        }


        private void Explode () {
            Despawn ();
            foreach (var v in Danmaku.Spray (-_v, Mathf.PI / 2, 3)) {
                The.World.Spawn (new Arrow (_p, v / 4, Color.Red));
            }
        }


        public override void Render () {
            The.Renderer.Bullets.DrawArrow (_p, _rotation, _color, 3);
        }

    }

}
using System;
using Microsoft.Xna.Framework;
using NupskouProject.Core;
using NupskouProject.Math;
using NupskouProject.Utils;


namespace NupskouProject.Raden.Bullets {

    public class Rocket : Entity {

        private readonly XY    _p0;
        private readonly XY    _v;
        private readonly Color _color;
        private readonly Color _smokeColor;

        private XY _p;


        public Rocket (XY p0, XY v, Color color) {
            _p     = _p0 = p0;
            _v     = v;
            _color = _smokeColor = color;

            _smokeColor.A /= 2;
        }


        public override void Update (int t) {
            The.World.Spawn (new Smoke (_p, _smokeColor, The.Random.Float (5, 10)));
            _p = _p0 + t * _v;
            if (!Geom.CircleOverBox (new Circle (_p, 8), World.Box)) {
                Despawn ();
            }
        }


        public override void Render () {
            The.Renderer.Bullets.DrawRocket (_p, _v.Angle, _color, 6);
        }

    }

}
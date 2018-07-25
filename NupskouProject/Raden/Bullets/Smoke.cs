using System;
using Microsoft.Xna.Framework;
using NupskouProject.Core;
using NupskouProject.Math;


namespace NupskouProject.Raden.Bullets {

    public class Smoke : Entity {

        private readonly XY    _p;
        private readonly Color _color;
        private readonly float _r0;

        private float _r;


        public Smoke (XY p, Color color, float r) {
            _p     = p;
            _color = color;
            _r0    = _r = r;
        }


        public override void Update (int t) {
            _r = _r0 - t * 0.2f;
            if (_r <= 0) Despawn ();
        }


        public override void Render () {
            The.Renderer.BulletsBack.DrawCircle (_p, _color, _r);
        }

    }


}
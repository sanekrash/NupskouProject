using System;
using Microsoft.Xna.Framework;
using NupskouProject.Core;
using NupskouProject.Math;


namespace NupskouProject.Raden.Bullets {

    public class Smoke : Entity {

        private readonly XY    _p;
        private readonly Color _color;
        private readonly float _r0;

        private int   _t0;
        private float _r;


        public Smoke (XY p, Color color, float r) {
            _p     = p;
            _color = color;
            _r0    = _r = r;
        }


        public override void OnSpawn () {
            _t0 = The.World.Time;
        }


        public override void Update () {
            _r = _r0 - (The.World.Time - _t0) * 0.2f;
            if (_r <= 0) {
                Despawn ();
            }
        }


        public override void Render () {
            The.Renderer.BulletsBack.DrawCircle (_p, _color, _r);
        }

    }


}
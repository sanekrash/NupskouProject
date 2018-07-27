﻿using Microsoft.Xna.Framework;
using NupskouProject.Core;
using NupskouProject.Math;
using NupskouProject.Utils;
using OpenGL;


namespace NupskouProject.Rashka.Bullets {

    public class VerticalBounceBullet : Entity {

        private readonly XY    _p0;
        private readonly XY    _v;
        private readonly float _rotation;
        private readonly Color _color;

        private XY _p;
        private bool _a = false;


        public VerticalBounceBullet (XY p0, XY v, Color color) {
            _p        = _p0 = p0;
            _v        = v;
            _color    = color;
            _rotation = _v.Angle;
        }


        public override void Update (int t) {
            _p = _p0 + t * _v;
            if (!Geom.CircleInVerticalBorders (new Circle (_p, 6), World.Box)) {
                Explode ();
            }
            _p = _p0 + t * _v;
            if (!Geom.CircleOverBox (new Circle (_p, 6), World.Box)) {
                Despawn ();                
            }

            _a = true;

        }


        private void Explode ()
        {
            if (_a) {
                Despawn();
                The.World.Spawn(new VerticalBounceBullet(_p/* + new XY(-_v.X, _v.Y)*/, new XY(-_v.X, _v.Y), _color));
            }
            else
            {
                _a = true;
            }
        }


        public override void Render () {
            The.Renderer.Bullets.DrawCircle (_p, _color,      6);
            The.Renderer.Bullets.DrawCircle (_p, Color.White, 4);
        }

    }

}
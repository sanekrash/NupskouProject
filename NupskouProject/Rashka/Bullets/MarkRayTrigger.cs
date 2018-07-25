﻿using Microsoft.Xna.Framework;
using Newtonsoft.Json;
using NupskouProject.Core;
using NupskouProject.Math;

namespace NupskouProject.Rashka.Bullets {

    public class MarkRayTrigger : Entity {

        private readonly XY _p;
        private readonly float _rotation;

        private int _t0;
        private float _wRay;
        private float _w;
        private Color _color;
        
        
        public MarkRayTrigger (XY p, float rotation, float wRay, Color color) {
            _p = p;
            _rotation = rotation;
            _wRay = wRay;
            _color = color;
            _w = 1;
        }


        public override void OnSpawn () { _t0 = The.World.Time; }


        public override void Update () {
            int t = The.World.Time - _t0;
            const int duration = 120;
            if (t >= duration) {
                Despawn ();
            }
            _w = _wRay * (duration - t) / duration;
        }
        
        public override void OnDespawn () {
            The.World.Spawn (new RayCast (_p,_rotation , _wRay, Color.Purple));
        }



        public override void Render () {
            var renderer = The.Renderer;
            
            renderer.Bullets.DrawCircle (_p, _color, 1);
            renderer.Bullets.DrawRay (_p, _rotation, _color, 1 * 2, 1000);
            renderer.BulletsFront.DrawCircle (_p, Color.White, 1 / 2);
            renderer.BulletsFront.DrawRay (_p, _rotation, Color.White, 1, 1000);
        }

    }

}